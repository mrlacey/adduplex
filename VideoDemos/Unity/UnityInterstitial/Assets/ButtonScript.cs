using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

	public void ShowInterstitialClicked () {
		Interop.ShowInterstitialAd ();
	}
}
