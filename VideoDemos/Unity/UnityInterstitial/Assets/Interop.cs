using UnityEngine;
using System.Collections;
using System;

public static class Interop {
	
	public static event EventHandler ShowInterstitialEvent;
	
	public static void ShowInterstitialAd()
	{
		if (ShowInterstitialEvent != null)
		{
			ShowInterstitialEvent(null, EventArgs.Empty);
		}
	}
}