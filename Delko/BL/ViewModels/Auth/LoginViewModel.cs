using Delko.BL.ViewModels.Profile;
using ReactiveUI;
using Splat;
using System.Windows.Input;

namespace Delko.BL.ViewModels.Auth
{
    public class LoginViewModel : ReactiveObject, IRoutableViewModel
    {
        public string UrlPathSegment => "Login Page";
        public IScreen HostScreen { get; }

        public LoginViewModel()
        {
            HostScreen = Locator.Current.GetService<IScreen>();

            LoginCommand = ReactiveCommand.CreateFromObservable(()=>
            {
                return HostScreen.Router.Navigate.Execute(new RegisterVehicleViewModel());
            });
        }

        public ICommand LoginCommand { get; }
    }
}
