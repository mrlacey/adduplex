using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.AdMediator.Core.Events;
using Microsoft.AdMediator.Core.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UwpAdMediator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();


            desk5.AdSdkOptionalParameters[AdSdkNames.AdDuplex]["IsTest"] = true;
            // desk5.AdSdkOptionalParameters[AdSdkNames.AdDuplex]["Height"] = 50;
            //  desk5.AdSdkOptionalParameters[AdSdkNames.AdDuplex]["Width"] = 300;
           // desk5.AdSdkOptionalParameters[AdSdkNames.AdDuplex]["Height"] = 80;
           // desk5.AdSdkOptionalParameters[AdSdkNames.AdDuplex]["Width"] = 480;

        }

        private void Desk5_OnAdMediatorError(object sender, AdMediatorFailedEventArgs e)
        {
            Debug.WriteLine("Desk5_OnAdMediatorError: " + e.Error);
}

        private void Desk5_OnAdMediatorFilled(object sender, AdSdkEventArgs e)
        {
            Debug.WriteLine("Desk5_OnAdMediatorFilled: " + e.EventName);
        }

        private void Desk5_OnAdSdkError(object sender, AdFailedEventArgs e)
        {
            Debug.WriteLine("Desk5_OnAdSdkError: " + e.Error);
        }

        private void Desk5_OnAdSdkEvent(object sender, AdSdkEventArgs e)
        {
            Debug.WriteLine("Desk5_OnAdSdkEvent: " + e.EventName);
        }
    }
}
