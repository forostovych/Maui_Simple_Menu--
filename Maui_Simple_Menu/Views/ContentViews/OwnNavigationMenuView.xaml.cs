using MAUI_Menu.Views.Models;
using MAUI_Menu.Views.Services;
using Maui_Simple_Menu;
using System.ComponentModel;
using Microsoft.Maui.Controls;
using MAUI_Menu.Views.ContentPages;

namespace CryptoBank.Views.ContentViews
{
    public partial class OwnNavigationMenuView : ContentView, INotifyPropertyChanged
    {
        SimpleIconSelectSrvice service;
        private CurrentIconModel _currentIconModel;

        public event PropertyChangedEventHandler PropertyChanged;

        public CurrentIconModel CurrentIconModel
        {
            get => _currentIconModel;
            set
            {
                if (_currentIconModel != value)
                {
                    _currentIconModel = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentIconModel)));
                }
            }
        }

        public OwnNavigationMenuView()
        {
            InitializeComponent();

            service = SimpleIconSelectSrvice.GetInstance();
            service.CurrentIconChanged += UpdateIcons;
            UpdateIcons();
            BindingContext = this;
        }

        private void UpdateIcons()
        {
            CurrentIconModel = service.GetActiveIcons();
        }

        private async void BTN_Wallet_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage(), false);
            service.SetActiveIcon(MenuPageActive.Wallet);
        }


        private async void BTN_Exchange3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Exchange(), false);
            service.SetActiveIcon(MenuPageActive.Exchange);
        }

        private async void BTN_Analytics_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AnalyticsPage(), false);
            service.SetActiveIcon(MenuPageActive.Analityc);
        }

        private async void BTN_Settings_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SettingsPage(), false);
            service.SetActiveIcon(MenuPageActive.Settings);
        }
    }
}
