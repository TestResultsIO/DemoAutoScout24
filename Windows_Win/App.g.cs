//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by the TestResults.io Designer.
// Designer Version: 5.2.7.0
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Progile.TRIO.BaseModel;
using Windows_Model.Screens;

namespace Windows_Model
{
    public partial class WindowsApp : IAppBasics
    {
        partial void InitScreens()
        {
            FileExplorer = new FileExplorer(this);
            FileProperties = new FileProperties(this);
        }


        public FileExplorer FileExplorer { get; set; }
        
        public FileProperties FileProperties { get; set; }
        
    }
}