using Delko.BL.ViewModels.Profile;
using ReactiveUI.XamForms;

namespace Delko.UI.Pages.Profile
{
    public partial class RegisterVehiclePage : ReactiveContentPage<RegisterVehicleViewModel>
    {
        public RegisterVehiclePage()
        {
            InitializeComponent();
            BindingContext = ViewModel = new RegisterVehicleViewModel();
        }
    }
}