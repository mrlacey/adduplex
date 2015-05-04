
namespace Interstitial
{
    using System.Windows;
    using Microsoft.Phone.Controls;

    public partial class SlInterMainPage : PhoneApplicationPage
    {
        public SlInterMainPage()
        {
            InitializeComponent();

            this.Loaded += SlInterMainPage_Loaded;
        }

        private void SlInterMainPage_Loaded(object sender, RoutedEventArgs e)
        {
            this.Loaded -= SlInterMainPage_Loaded;

        }

        private void ShowInterstitialClicked(object sender, RoutedEventArgs e)
        {
            AdDuplex.InterstitialAd interstitialAd = new AdDuplex.InterstitialAd("149451");
            interstitialAd.ShowAd();
                    
        }
    }
}