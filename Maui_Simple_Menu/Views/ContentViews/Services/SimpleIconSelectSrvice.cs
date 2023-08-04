using MAUI_Menu.Views.Models;
using System;

namespace MAUI_Menu.Views.Services
{
    public class SimpleIconSelectSrvice
    {
        private static SimpleIconSelectSrvice instance = null;

        private CurrentIconModel currentIcons;
        private MenuPageActive currentActiveIcon;

        public event Action CurrentIconChanged;

        private SimpleIconSelectSrvice()
        {
            currentIcons = new CurrentIconModel()
            {
                WalletIcon = "wallet.svg",
                ExchangeIcon = "exchange.svg",
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
            currentActiveIcon = activeIcon;
            currentIcons = SetCurrentIcons(activeIcon);
            CurrentIconChanged?.Invoke();
        }

        public CurrentIconModel GetActiveIcons()
        {
            return currentIcons;
        }

        private CurrentIconModel SetCurrentIcons(MenuPageActive activeIcon)
        {
            CurrentIconModel currentIcons = new CurrentIconModel();

            switch (activeIcon)
            {
                case MenuPageActive.Wallet:
                    currentIcons.WalletIcon = "yellowwallet.svg";
                    currentIcons.ExchangeIcon = "exchange.svg";
                    break;
                case MenuPageActive.Analityc: 
                case MenuPageActive.Settings:
                    currentIcons.WalletIcon = "wallet.svg";
                    currentIcons.ExchangeIcon = "exchange.svg";
                    break;
                case MenuPageActive.Exchange:
                    currentIcons.WalletIcon = "wallet.svg";
                    currentIcons.ExchangeIcon = "yellowexchange.svg";
                    break;
            }

            return currentIcons;
        }
    }
}
