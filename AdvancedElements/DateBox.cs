using Progile.ATE.Common;
using Progile.ATE.TestFramework;
using Progile.TRIO.BaseModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdvancedElements
{
    [ScreenElements(
    "appBasics:AppBasics",
    "displayName:string:Name",
    "searchType:SearchType{Image,Text}:Search type:notInCtor:$hint$ How to locate the element on the screen",
    "imageReference:Image:Image:(Image):$hint$ The label used to locate the element (e.g. \"Username:\").\n" +
        "Put the hotspot inside the textbox, or use VisualSense to automatically detect the textbox.",
    "useVisualSense:bool:Use VisualSense:true:(Image):$hint$ " +
        "Detects the corresponding textbox rectangle for the element and highlights it on the screen.\n" +
        "Middle of detected rectangle will be used for interaction instead of hotspot.",
    "searchText:string:Search text:(Text):$hint$ The label text used to locate the element (e.g. \"Username:\").",
    "filters:ScreenSelect",
    Hint = "A textbox that allows to enter a date in a date box (with split boxes for day, month and year) and verify the displayed text.\n" +
        "Text is verified either through OCR by default.",
    ElementName = "Date Textbox")]
    [DesignerControlColor("Blue")]
    public class DateBox : TextBox
    {
        public DateBox(IAppBasics appBasics, string displayName, string searchText, params IImageFilter[] filters) : 
            base(appBasics, displayName, searchText, filters)
        {
            TextBoxType = TextBoxType.OCR;
        }

        public DateBox(IAppBasics appBasics, string displayName, ImageReference imageReference, bool useVisualSense, params IImageFilter[] filters) : 
            base(appBasics, displayName, imageReference, useVisualSense, filters)
        {
            TextBoxType = TextBoxType.OCR;
        }

        [ScreenEditorProperty("Date format", "The format which is used to enter the date. Use \t to specify a Tab key press to switch to next box. \n\r" +
            "Default: ddMMyyy")]
        public string DateFormat { get; set; } = "ddMMyyyy";

        [ModelCapability("Enter date", Hint = @"Clicks in the textbox, and types the specified date in the format according to the DateFormat property. 
The entered date is verified by text detection (OCR).
If the verification fails, retries are performed.")]
        public virtual void EnterDate([DisplayName("date to enter")] DateTime dateToEnter)
        {
            string text = dateToEnter.ToString(DateFormat);
            EnterWithoutVerification(text);
        }


        public override void Enter([DisplayName("Text to enter")] string textToEnter)
        {
            DateTime.TryParse(Lookup(textToEnter), out DateTime dateTime);
            EnterDate(dateTime);
        }

        protected override void EnterTextImpl(string textToEnter)
        {
            ClickInTextbox();

            if (SelectAllAfterFocusClick)
                _systemInteractions.SelectAll();

            if (string.IsNullOrEmpty(textToEnter))
            {
                t.Testee.Keyboard.Press(Keys.Delete);
                return;
            }

            var sections = Regex.Split(Lookup(textToEnter), "\t");
            t.Testee.Keyboard.Type(sections.First());

            foreach (string section in sections.Skip(1))
            {
                t.Testee.Keyboard.Press(Keys.Tab);
                t.Testee.Keyboard.Type(section);
            }
        }
    }
}
