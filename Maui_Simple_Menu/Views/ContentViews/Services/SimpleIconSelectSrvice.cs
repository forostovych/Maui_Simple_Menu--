using MAUI_Menu.Views.Models;

namespace MAUI_Menu.Views.Services
{
    public class SimpleIconSelectSrvice
    {
        public event Action CurrentIconChanged;
        private static MenuPageActive currentActiveIcon { get; set; }
        private static CurrentIconModel currrentIcons { get; set; } = new CurrentIconModel();

        public SimpleIconSelectSrvice()
        {
            currrentIcons = new CurrentIconModel()
            {
                WalletIcon = "wallet.svg",
                AnalitycIcon = "analitycs.svg",
                ExchangeIcon = "exchange.svg",
            };
        }
        public void SetActiveIcon(MenuPageActive activeIcon)
        {
            currentActiveIcon = activeIcon;
            currrentIcons = SetCurrentIcons(activeIcon);
            CurrentIconChanged?.Invoke(); // Notify listeners that the active icon has changed
        }
        public CurrentIconModel GetActiveIcons()
        {
            return currrentIcons;
        }
        private CurrentIconModel SetCurrentIcons(MenuPageActive activeIcon)
        {
            CurrentIconModel currrentIcons = new CurrentIconModel();
            switch (activeIcon)
            {
                case MenuPageActive.Wallet:
                {
                    currrentIcons.WalletIcon = "wallet.svg";
                    currrentIcons.AnalitycIcon = "analitycs.svg";
                    currrentIcons.ExchangeIcon = "exchange.svg";
                    break;
                }
                case MenuPageActive.Analityc:
                {
                    currrentIcons.WalletIcon = "wallet.svg";
                    currrentIcons.AnalitycIcon = "yellowanalitycs.svg";
                    currrentIcons.ExchangeIcon = "exchange.svg";
                    break;
                }
                case MenuPageActive.Exchange:
                {
                    currrentIcons.WalletIcon = "wallet.svg";
                    currrentIcons.AnalitycIcon = "analitycs.svg";
                    currrentIcons.ExchangeIcon = "yellowexchange.svg";
                    break;
                }
                case MenuPageActive.Settings:
                {
                    currrentIcons.WalletIcon = "wallet.svg";
                    currrentIcons.AnalitycIcon = "analitycs.svg";
                    currrentIcons.ExchangeIcon = "exchange.svg";
                    break;
                }
            }
            return currrentIcons;
        }
    }
}
