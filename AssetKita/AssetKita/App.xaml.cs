using Prism;
using Prism.Ioc;
using AssetKita.ViewModels;
using AssetKita.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.DryIoc;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AssetKita
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/Main_TabbedPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<Main_TabbedPage, Main_TabbedPage_ViewModel>();
            containerRegistry.RegisterForNavigation<ItemList_Gadai_Page, ItemList_Gadai_ViewModel>();
            containerRegistry.RegisterForNavigation<ItemList_Invest_Page, ItemList_Invest_ViewModel>();
            containerRegistry.RegisterForNavigation<Item_TabbedPage, Item_TabbedPage_ViewModel>();
        }
    }
}
