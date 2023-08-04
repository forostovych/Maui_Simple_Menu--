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
        // �������� ���� �������������, ����� �������� ����� �������� ������
        // ��������, �� ������ ������� ����� GetActiveIcons() � ������������ ���������� ��������
    }

}