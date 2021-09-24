using System.Collections;
using System;
using UnityEngine;
using GoogleMobileAds.Api;
//GameObject.Find("AD").GetComponent<AdmobInterstitialScript>().show();
public class AdmobInterstitialScript : MonoBehaviour
{

    private readonly string InterstitialID = "	ca-app-pub-3940256099942544/8691691433";

    private InterstitialAd _interAd;
    public static bool _showAd = false;


    void Start()
    {
        _interAd = new InterstitialAd(InterstitialID);

        _interAd.OnAdClosed += oac;

        
        load();
    }


    private void load()
    {
        AdRequest _request = new AdRequest.Builder().Build();
        _interAd.LoadAd(_request);
    }


    public void show()
    {
        StartCoroutine("showInterAd");
    }

    private IEnumerator showInterAd()
    {
        while (!_interAd.IsLoaded())
        {
            yield return null;
        }
        _interAd.Show();
    }


    public void oac(object sender, EventArgs args)
    {
        _interAd.Destroy();
        load();
    }

}
