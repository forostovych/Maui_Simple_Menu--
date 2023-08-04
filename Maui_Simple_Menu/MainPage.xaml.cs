using CryptoBank.Views.ContentViews;

namespace Maui_Simple_Menu;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
        LAYOUT_Menu_Select.Content = new OwnNavigationMenuView();
        BindingContext = this;
    }

}

