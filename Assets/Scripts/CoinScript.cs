using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;

public class CoinScript : MonoBehaviour
{
    public GameObject EndScreen;

    public int lvl;

    private InterstitialAd interstitial;

    public string appId = ""; //appID from Unity goes here, removed from source code for privacy purposes

    public string adUnitId = ""; //adUnityId goes here, removed from source code for privacy purposes

    void Start()
    {
        Time.timeScale = 1;

        MobileAds.Initialize(appId);

        interstitial = new InterstitialAd(adUnitId);

        AdRequest request = new AdRequest.Builder().Build();

        interstitial.LoadAd(request);

    }

    void Update()
    {
        transform.Rotate(0, 4, 0, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {

        Time.timeScale = 0;

        if (interstitial.IsLoaded())
        {
            interstitial.Show();
            interstitial.Destroy();
        }

        if (other.name == "Player")
        {

            if (PlayerPrefs.GetInt("HighestLvl") >= lvl)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("Level Select");
            }

            else if (PlayerPrefs.GetInt("HighestLvl", 0) < lvl)
            {
                PlayerPrefs.SetInt("HighestLvl", lvl);

                Destroy(gameObject);

                EndScreen.SetActive(true);
            }

        }
    }

}
