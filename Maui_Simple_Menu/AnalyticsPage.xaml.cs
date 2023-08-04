using CryptoBank.Views.ContentViews;
using MAUI_Menu.Views.Services;

namespace MAUI_Menu.Views.ContentPages;
public partial class AnalyticsPage : ContentPage
{
    SimpleIconSelectSrvice service;

    public AnalyticsPage()
    {
        InitializeComponent();
        LAYOUT_Menu_Select.Content = new OwnNavigationMenuView();
        BindingContext = this;
        service = SimpleIconSelectSrvice.GetInstance();
    }


}