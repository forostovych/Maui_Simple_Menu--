using System.ComponentModel;
namespace MAUI_Menu.Views.Models;

public class CurrentIconModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    private string _walletIcon = "wallet.svg";
    private string _exchangeIcon = "exchange.svg";
    private string _analitycIcon = "analitycs.svg";

    public string WalletIcon
    {
        get => _walletIcon;
        set
        {
            if (_walletIcon != value)
            {
                _walletIcon = value;
                OnPropertyChanged(nameof(WalletIcon));
            }
        }
    }
    public string ExchangeIcon
    {
        get => _exchangeIcon;
        set
        {
            if (_exchangeIcon != value)
            {
                _exchangeIcon = value;
                OnPropertyChanged(nameof(ExchangeIcon));
            }
        }
    }
    public string AnalitycIcon
    {
        get => _analitycIcon;
        set
        {
            if (_analitycIcon != value)
            {
                _analitycIcon = value;
                OnPropertyChanged(nameof(AnalitycIcon));
            }
        }
    }

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
