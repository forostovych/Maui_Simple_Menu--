using MAUI_Menu.Views.Models;
using MAUI_Menu.Views.Services;
using Maui_Simple_Menu;
using System.ComponentModel;

namespace CryptoBank.Views.ContentViews
{
    public partial class OwnNavigationMenuView : ContentView, INotifyPropertyChanged
    {
        private SimpleIconSelectSrvice _simpleIconSelectSrvice;
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

            _simpleIconSelectSrvice = new SimpleIconSelectSrvice();
            _simpleIconSelectSrvice.CurrentIconChanged += UpdateIcons;
            UpdateIcons();
            BindingContext = this;
        }

        private void UpdateIcons()
        {
            CurrentIconModel = _simpleIconSelectSrvice.GetActiveIcons();
        }

        private async void BTN_Wallet_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage(), true);
            await Task.Delay(1000);
            _simpleIconSelectSrvice.SetActiveIcon(MenuPageActive.Wallet);
        }


        private async void BTN_Exchange3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Exchange(), true);
            await Task.Delay(1000);
            _simpleIconSelectSrvice.SetActiveIcon(MenuPageActive.Exchange);
        }

        private async void BTN_Analytics_Clicked(object sender, EventArgs e)
        {
            // Here you can change the page based on your requirements
        }
    }
}
