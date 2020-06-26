using Delko.BL.ViewModels.Auth;
using Delko.BL.ViewModels.Profile;
using Delko.UI.Pages.Auth;
using Delko.UI.Pages.Profile;
using ReactiveUI;
using ReactiveUI.XamForms;
using Splat;
using Xamarin.Forms;

namespace Delko
{
    public class AppBootstrapper : ReactiveObject, IScreen
    {
        public RoutingState Router { get; }

        public AppBootstrapper()
        {
            Router = new RoutingState();
            Locator.CurrentMutable.RegisterConstant(this, typeof(IScreen));

            RegisterViews();
            Router.Navigate.Execute(new LoginViewModel());
        }

        private void RegisterViews()
        {
            Locator.CurrentMutable.Register(() => new LoginPage(), typeof(IViewFor<LoginViewModel>));
            Locator.CurrentMutable.Register(() => new RegisterVehiclePage(), typeof(IViewFor<RegisterVehicleViewModel>));
        }

        public Page CreateMainPage()
        {
            return new RoutedViewHost();
        }
    }
}
