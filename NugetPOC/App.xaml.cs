using Xamarin.Forms;
using FreshMvvm;
using NugetPOC.ViewModels;

namespace NugetPOC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Page page = FreshPageModelResolver.ResolvePageModel<BioViewModel>();
            FreshNavigationContainer container = new FreshNavigationContainer(page);
            MainPage = container;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
