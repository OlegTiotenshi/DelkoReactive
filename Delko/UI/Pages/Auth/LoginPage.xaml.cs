using Delko.BL.ViewModels.Auth;
using ReactiveUI.XamForms;

namespace Delko.UI.Pages.Auth
{
    public partial class LoginPage : ReactiveContentPage<LoginViewModel>
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = ViewModel = new LoginViewModel();
        }
    }
}