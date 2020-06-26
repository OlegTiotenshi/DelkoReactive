using ReactiveUI;

namespace Delko.BL.ViewModels.Profile
{
    public class RegisterVehicleViewModel : ReactiveObject, IRoutableViewModel
    {
        public string UrlPathSegment => "Register Vehicle Page";
        public IScreen HostScreen { get; }
    }
}
