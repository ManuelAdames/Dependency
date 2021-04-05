using Dependency.ViewModels;
using Dependency.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Dependency.ViewModels;
using Prism.DryIoc;

namespace Dependency
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer = null) : base(platformInitializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync(Config.Home);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage, ViewModelBase>();
            containerRegistry.RegisterForNavigation<NavigationPage>(Config.Navigate);
        }
    }
}