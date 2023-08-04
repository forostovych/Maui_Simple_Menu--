using MAUI_Menu.Views.Models;
using System.Collections.Generic;

namespace MAUI_Menu.Views.Services
{
    public class SimpleIconSelectService
    {
        private static SimpleIconSelectService instance = null;
        private CurrentIconModel currentIcons;
        public event Action CurrentIconChanged;

        private Dictionary<MenuPageActive, CurrentIconModel> iconDictionary;

        private SimpleIconSelectService()
        {
            iconDictionary = new Dictionary<MenuPageActive, CurrentIconModel>()
            {
                { MenuPageActive.Wallet, new CurrentIconModel { WalletIcon = "yellowwallet.svg", ExchangeIcon = "exchange.svg", AnalitycIcon = "analitycs.svg", SettingIcon = "settings.svg" } },
                { MenuPageActive.Analityc, new CurrentIconModel { WalletIcon = "wallet.svg", ExchangeIcon = "exchange.svg", AnalitycIcon = "yellowanalitycs.svg", SettingIcon = "settings.svg" } },
                { MenuPageActive.Exchange, new CurrentIconModel { WalletIcon = "wallet.svg", ExchangeIcon = "yellowexchange.svg", AnalitycIcon = "analitycs.svg", SettingIcon = "settings.svg" } },
                { MenuPageActive.Settings, new CurrentIconModel { WalletIcon = "wallet.svg", ExchangeIcon = "exchange.svg", AnalitycIcon = "analitycs.svg", SettingIcon = "yellowsettings.svg" } }
            };
            SetActiveIcon(MenuPageActive.Wallet);
        }

        public static SimpleIconSelectService GetInstance()
        {
            if (instance == null)
            {
                instance = new SimpleIconSelectService();
            }

            return instance;
        }

        public void SetActiveIcon(MenuPageActive activeIcon)
        {
            currentIcons = iconDictionary[activeIcon];
            CurrentIconChanged?.Invoke();
        }

        public CurrentIconModel GetActiveIcons() => currentIcons;
    }
}
