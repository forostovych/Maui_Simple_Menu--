using CryptoBank.Views.ContentViews;

namespace Maui_Simple_Menu;

public partial class Exchange : ContentPage
{
	public Exchange()
	{
        InitializeComponent();
        LAYOUT_Menu_Select.Content = new OwnNavigationMenuView();
        BindingContext = this;
    }
}