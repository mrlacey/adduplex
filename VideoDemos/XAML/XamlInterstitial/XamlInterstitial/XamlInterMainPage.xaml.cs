
namespace XamlInterstitial
{
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Navigation;

    public sealed partial class XamlInterMainPage : Page
    {
        public XamlInterMainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        private void ShowInterstitialClicked(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            AdDuplex.Universal.Controls.WinPhone.XAML.InterstitialAd interstitialAd = new AdDuplex.Universal.Controls.WinPhone.XAML.InterstitialAd("149515");
            interstitialAd.ShowAd();
                    
        }
    }
}
