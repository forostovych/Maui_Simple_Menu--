using MAUI_Menu.Views.Models;
using MAUI_Menu.Views.Services;
using Maui_Simple_Menu;

namespace CryptoBank.Views.ContentViews
{
    public class OwnMenuPageFactory
    {
        private static SimpleIconSelectSrvice simpleIconSelectSrvice = new SimpleIconSelectSrvice();
        public OwnMenuPageFactory() 
        {
            simpleIconSelectSrvice = new SimpleIconSelectSrvice();
        }

        public static ContentPage GetWalletPage()
        {
            simpleIconSelectSrvice.SetActiveIcon(MenuPageActive.Wallet);
            return new MainPage();
        }
        public static ContentPage GetExchangePage()
        {
            simpleIconSelectSrvice.SetActiveIcon(MenuPageActive.Exchange);
            return new Exchange();
        }

        public static ContentView GetMenu()
        {
            var res = new OwnNavigationMenuView();
            return res;
        }
    }
}
