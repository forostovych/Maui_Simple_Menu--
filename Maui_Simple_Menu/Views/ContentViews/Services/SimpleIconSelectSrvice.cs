using MAUI_Menu.Views.Models;
using System;

namespace MAUI_Menu.Views.Services
{
    public class SimpleIconSelectSrvice
    {
        private static SimpleIconSelectSrvice instance = null;
        private CurrentIconModel currentIcons;
        public event Action CurrentIconChanged;

        private SimpleIconSelectSrvice()
        {
            currentIcons = new CurrentIconModel()
            {
                WalletIcon = "yellowwallet.svg",
                ExchangeIcon = "exchange.svg",
                AnalitycIcon = "analitycs.svg",
                SettingIcon = "settings.svg",
            };
        }

        public static SimpleIconSelectSrvice GetInstance()
        {
            if (instance == null)
            {
                instance = new SimpleIconSelectSrvice();
            }

            return instance;
        }

        public void SetActiveIcon(MenuPageActive activeIcon)
        {
            currentIcons = SetCurrentIcons(activeIcon);
            CurrentIconChanged?.Invoke();
        }

        public CurrentIconModel GetActiveIcons() => currentIcons;

        private CurrentIconModel SetCurrentIcons(MenuPageActive activeIcon)
        {
            switch (activeIcon)
            {
                case MenuPageActive.Wallet:
                    {
                        currentIcons.WalletIcon = "yellowwallet.svg";
                        currentIcons.AnalitycIcon = "analitycs.svg";
                        currentIcons.ExchangeIcon = "exchange.svg";
                        currentIcons.SettingIcon = "settings.svg";
                        break;
                    }
                case MenuPageActive.Analityc:
                    {
                        currentIcons.WalletIcon = "wallet.svg";
                        currentIcons.AnalitycIcon = "yellowanalitycs.svg";
                        currentIcons.ExchangeIcon = "exchange.svg";
                        currentIcons.SettingIcon = "settings.svg";
                        break;
                    }
                case MenuPageActive.Exchange:
                    {
                        currentIcons.WalletIcon = "wallet.svg";
                        currentIcons.AnalitycIcon = "analitycs.svg";
                        currentIcons.ExchangeIcon = "yellowexchange.svg";
                        currentIcons.SettingIcon = "settings.svg";
                        break;
                    }
                case MenuPageActive.Settings:
                    {
                        currentIcons.WalletIcon = "wallet.svg";
                        currentIcons.AnalitycIcon = "analitycs.svg";
                        currentIcons.ExchangeIcon = "exchange.png";
                        currentIcons.SettingIcon = "yellowsettings.svg";
                        break;
                    }
            }
            return currentIcons;
        }
    }
}
