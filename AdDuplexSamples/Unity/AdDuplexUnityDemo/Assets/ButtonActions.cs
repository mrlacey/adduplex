using UnityEngine;
using System.Collections;

public class ButtonActions : MonoBehaviour {
	
	public void ToggleBannerAd () {
		Interop.ToggleBannerAdControl();
	}
	
	public void ShowInterstitial () {
		Interop.ShowInterstitialAd(); 
	}
}
