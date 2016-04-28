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
using Microsoft.AdMediator.Core.Models;
using Microsoft.AdMediator.Core.Utilities;
using Microsoft.AdMediator.Windows81;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace UniversalMediator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            
            this.AdMediator_6E6F90.AdMediatorFilled += AdMediator_6E6F90_AdMediatorFilled;
        }

        private void AdMediator_6E6F90_AdMediatorFilled(object sender, Microsoft.AdMediator.Core.Events.AdSdkEventArgs e)
        {
            // VS may put red underlines here but can ignore them
             this.AdMediator_6E6F90.AdSdkOptionalParameters[AdSdkNames.AdDuplex]["Size"] = "160×600";

            //this.AdMediator_6E6F90.AdSdkOptionalParameters[AdSdkNames.AdDuplex]["Width"] = 160;
            //this.AdMediator_6E6F90.AdSdkOptionalParameters[AdSdkNames.AdDuplex]["Height"] = 600;
        }
    }

}
