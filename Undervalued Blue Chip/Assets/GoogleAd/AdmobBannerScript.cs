using UnityEngine;
using GoogleMobileAds.Api;

public class AdmobBannerScript : MonoBehaviour
{
    static bool isAdsBannerLoaded = false;
    
    void Start()
    {
        isAdsBannerLoaded = false;
        if (!isAdsBannerLoaded)
            RequestBanner();
    }

    private void RequestBanner()
    {

        string BannerID = "ca-app-pub-3940256099942544/6300978111";
        BannerView bannerview = new BannerView(BannerID, AdSize.SmartBanner, AdPosition.Bottom);

        AdRequest request = new AdRequest.Builder().Build();
        bannerview.LoadAd(request);
        isAdsBannerLoaded = true;
    }
}
