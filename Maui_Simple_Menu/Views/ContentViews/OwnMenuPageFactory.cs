using MAUI_Menu.Views.Models;
using MAUI_Menu.Views.Services;
using Maui_Simple_Menu;

namespace CryptoBank.Views.ContentViews
{
    public class OwnMenuPageFactory
    {
        public OwnMenuPageFactory() 
        {
        }

        public static ContentPage GetWalletPage()
        {
            return new MainPage();
        }
        public static ContentPage GetExchangePage()
        {
            return new Exchange();
        }

        public static ContentView GetMenu()
        {
            var res = new OwnNavigationMenuView();
            return res;
        }
    }
}
