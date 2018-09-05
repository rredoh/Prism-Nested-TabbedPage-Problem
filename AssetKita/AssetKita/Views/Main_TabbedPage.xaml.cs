using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace AssetKita.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Main_TabbedPage : Xamarin.Forms.TabbedPage
    {
        public Main_TabbedPage ()
        {
            InitializeComponent();

            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(Xamarin.Forms.PlatformConfiguration.AndroidSpecific.ToolbarPlacement.Bottom);
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetBarSelectedItemColor((Color)App.Current.Resources["PrimaryGreenColor"]);
        }
    }
}