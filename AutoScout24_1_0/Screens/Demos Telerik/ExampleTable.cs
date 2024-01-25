
using System;
using Progile.TRIO.BaseModel;

namespace AutoScout24_Model.Screens.DemosTelerik
{
	public partial class ExampleTable
	{
        protected override void Initialize()
		{
			base.Initialize();
			// Define table rectangle as search area for column headers and rows:
			// By default we determine the rectangle with a color fill starting from the top left position of the table loaded image.
			// If required, adjust the tolerance value, so that the color fill will return the whole table.
			// In some cases, color fill is not suitable to determine the table rect, in this case define it manually with e.g. ResultRectangle.FromLTRB
			TableRect = t.SelectFromColorAtPoint(Position.Boundary.TopLeft, tolerance: 0.2).Bounds;
		}

        public void AddNewEntry(string productName)
        {
            App.EditableTableScreen.AddNewRecordButton.ClickWithUpdateCheck(ImgDiffTolerance.Low);

            //for the Textbox we use the "ProductName" Column Header as the reference Image and set the Hotspot down below in the Textbox
            App.EditableTableScreen.NewProductNameTextbox.Enter(productName); //also presses the Enter Key to confirm the entry, because we set the Advanced setting when creating the button
        }

		public void DeleteEntry(string productName)
		{
			var row = GetRow(ColumnProductName, productName);
			Button deleteButton = row.GetElementInRow(App.EditableTableScreen.DeleteRowButton); //Get the button that is in the correct row
			deleteButton.Click(App.EditableTableScreen.DeleteRecordConfirmation.WaitForAppear);
			App.EditableTableScreen.DeleteRecordConfirmation.Click(App.EditableTableScreen.DeleteRecordConfirmation.WaitForDisappear);
        }
    }
}
