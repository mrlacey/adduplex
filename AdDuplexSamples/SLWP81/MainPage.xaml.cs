
using System.Windows;
using Microsoft.Phone.Controls;

namespace SLWP81
{
    public partial class MainPage : PhoneApplicationPage
    {
        AdDuplex.InterstitialAd interstitialAd;

        public MainPage()
        {
            InitializeComponent();

            this.Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            this.Loaded -= MainPage_Loaded;

            // Don't try creating the ad until the page has loaded
            interstitialAd = new AdDuplex.InterstitialAd("YOUR_AD_UNIT_ID");

            // This is optional but should improve the performance when displaying the ad/image
            interstitialAd.LoadAd();
        }

        private void ShowInterstitialTapped(object sender, System.Windows.Input.GestureEventArgs e)
        {
            interstitialAd.ShowAd();
        }
    }
}
