using Delko.BL.ViewModels.Menu;
using ReactiveUI.XamForms;

namespace Delko.UI.Pages.Menu
{
    public partial class MenuPage : ReactiveContentPage<MenuViewModel>
    {
        public MenuPage()
        {
            InitializeComponent();
            BindingContext = ViewModel = new MenuViewModel();
        }
    }
}