using Microsoft.AdMediator.Core.Events;
using Microsoft.Phone.Controls;

namespace SLWP81Mediator
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AdMediator_A219F9_OnAdMediatorError(object sender, AdMediatorFailedEventArgs e)
        {
            System.Diagnostics.Debugger.Break();
        }

        private void AdMediator_A219F9_OnAdSdkError(object sender, AdFailedEventArgs e)
        {
            System.Diagnostics.Debugger.Break();
        }
    }
}