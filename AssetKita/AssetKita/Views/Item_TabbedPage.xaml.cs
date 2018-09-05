using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AssetKita.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Item_TabbedPage : TabbedPage
    {
        public Item_TabbedPage()
        {
            InitializeComponent();
        }
    }
}