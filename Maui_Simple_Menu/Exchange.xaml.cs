using CryptoBank.Views.ContentViews;
using MAUI_Menu.Views.Services;

namespace Maui_Simple_Menu;

public partial class Exchange : ContentPage
{
    SimpleIconSelectService service;

    public Exchange()
	{
        InitializeComponent();
        LAYOUT_Menu_Select.Content = new OwnNavigationMenuView();
        BindingContext = this;
        service = SimpleIconSelectService.GetInstance();
        service.CurrentIconChanged += OnCurrentIconChanged;
    }

    private void OnCurrentIconChanged()
    {
        // ќбновите свое представление, чтобы отразить новые значени€ иконок
        // Ќапример, вы можете вызвать метод GetActiveIcons() и использовать полученные значени€
    }

}