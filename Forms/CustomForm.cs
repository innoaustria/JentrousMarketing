using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace JentrousMarketing.Forms
{
    public class CustomForm:RadForm
    {
        private Telerik.WinControls.Themes.DesertTheme DesertTheme;
    
        public CustomForm()
        {
            DesertTheme = new Telerik.WinControls.Themes.DesertTheme();
            Name = "CustomForm";
            ThemeName = "Desert";
            ThemeResolutionService.ApplicationThemeName = ThemeName;
        }
    }
}
