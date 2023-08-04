using CryptoBank.Views.ContentViews;
using MAUI_Menu.Views.Services;

namespace Maui_Simple_Menu;

public partial class SettingsPage : ContentPage
{
    SimpleIconSelectSrvice service;

    public SettingsPage()
    {
        InitializeComponent();
        LAYOUT_Menu_Select.Content = new OwnNavigationMenuView();
        BindingContext = this;
        service = SimpleIconSelectSrvice.GetInstance();
        service.CurrentIconChanged += OnCurrentIconChanged;
    }

    private void OnCurrentIconChanged()
    {
        // ќбновите свое представление, чтобы отразить новые значени€ иконок
        // Ќапример, вы можете вызвать метод GetActiveIcons() и использовать полученные значени€
    }

}