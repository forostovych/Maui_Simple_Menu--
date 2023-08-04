using MAUI_Menu.Views.Models;
using MAUI_Menu.Views.Services;
using Maui_Simple_Menu;
using System.ComponentModel;
using Microsoft.Maui.Controls;

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
            await Navigation.PushModalAsync(new MainPage(), true);
            service.SetActiveIcon(MenuPageActive.Wallet);
        }


        private async void BTN_Exchange3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Exchange(), true);
            service.SetActiveIcon(MenuPageActive.Exchange);
        }

        private async void BTN_Analytics_Clicked(object sender, EventArgs e)
        {
            // Here you can change the page based on your requirements
        }
    }
}
