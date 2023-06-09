using Progile.ATE.Common;
using Progile.TRIO.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoScout24_Model.CustomScreenElements
{
    [ScreenElements(
        "appBasics:AppBasics",
        "displayName:string:Name",
        "imageReference:Image:Textbox image",
        "useVisualSense:bool:Use VisualSense",
        "filters:ScreenSelect")]
    [DesignerControlColor("DarkPurple")]
    public class DropdownWithSearchbox : Dropdown
    {
        /// <summary>
        /// Creates a new MultiSelectDropdown instance. Dropdown Textbox will be defined by the visible closed border around the hotspot of the provided image.
        /// This special dropdown allows to select multiple values.
        /// </summary>
        /// <param name="appBasics">The interface for the AppBasics, that is available on every BaseScreen. Allows access to the tester and the application window.</param>
        /// <param name="displayName">The name of the element that will be used for logging and reporting of exceptions (customer facing).</param>
        /// <param name="imageReference">The image that will be used to locate the Dropdown on the screen. The Hotspot of the image must be set within the dropdown textbox.</param>
        /// <param name="filters">Typically a Select filter indicating the area of interest for the image search.</param>
        public DropdownWithSearchbox(IAppBasics appBasics, string displayName, ImageReference imageReference, bool useVisualSense, params IImageFilter[] filters) :
            base(appBasics, displayName, imageReference, useVisualSense, filters)
        {
            TextBox.TextBoxType = TextBoxType.OCR;
            TextBox.ClickOutAfterType = false; //because value is lost
            TextBox.ClickOutBeforeOCR = false;
        }

        /// <summary>
        /// Opens the dropdownlist, enters the textbox Value into the searchBox to filter the dropdown
        /// Selects the dropdown Value in the Dropdown
        /// </summary>
        /// <param name="values">The values that shall be selected in the dropdown list.</param>
        /// <exception cref="ElementNotFoundException">When the dropdown could not be found on the screen.</exception>
        /// <exception cref="InteractionFailedException">When the dropdown could not be opened after the configured amount of retries.</exception>
        /// <exception cref="TestStepAbortedException">When the text value cannot be found in the dropdown list.</exception>
        [ModelCapability("SelectValueWithSearch")]
        public void SelectValueWithSearch(
            [DisplayName("Textbox search Value")] string textboxValue, 
            [DisplayName("Select Value in Dropdown")] string dropdownValue
        )
        {
            OpenDropdownList();
            TextBox.Enter(textboxValue);
            Row row = DropdownList.GetRow(dropdownValue);
            row.SetSelectFilter(row.RowSelect);
            row.SelectRow(row.WaitForDisappear);
        }

        [ModelCapability("SelectValueWithSearch")]
        public void SelectValueWithSearch([DisplayName("Value")] string value)
        {
            SelectValueWithSearch(value, value);
        }
    }
}

