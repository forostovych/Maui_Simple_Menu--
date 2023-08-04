using CryptoBank.Views.ContentViews;
using MAUI_Menu.Views.Services;

namespace Maui_Simple_Menu;

public partial class MainPage : ContentPage
{
    SimpleIconSelectSrvice service;

    public MainPage()
    {
        InitializeComponent();
        LAYOUT_Menu_Select.Content = new OwnNavigationMenuView();
        BindingContext = this;
        service = SimpleIconSelectSrvice.GetInstance();
        service.CurrentIconChanged += OnCurrentIconChanged;
    }


    private void OnCurrentIconChanged()
    {
        // Обновите свое представление, чтобы отразить новые значения иконок
        // Например, вы можете вызвать метод GetActiveIcons() и использовать полученные значения
    }
}

