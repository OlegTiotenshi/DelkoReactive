using ReactiveUI;

namespace Delko.BL.ViewModels.Menu
{
    public class MenuViewModel : ReactiveObject, IRoutableViewModel
    {
        public string UrlPathSegment => "Menu Page";
        public IScreen HostScreen { get; }
    }
}
