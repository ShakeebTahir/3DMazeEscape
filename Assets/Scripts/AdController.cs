using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class AdController : MonoBehaviour, IUnityAdsListener
{

    private string gameId = "3226171";

    public string rewardedVideo = "rewardedVideo";

    public Button watchVideoButton;

    bool testMode = false;

    private int moneyAmount;

    public Text moneyAmountText;

    public GameObject tryLater;

    void Start()
    {
        Advertisement.Initialize(gameId, testMode);

        Advertisement.AddListener(this);

        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");

        watchVideoButton.interactable = false;
    }

    void Update()
    {
        moneyAmountText.text = " " + moneyAmount.ToString();

        if (Advertisement.IsReady(rewardedVideo))
        {
            tryLater.SetActive(false);
            watchVideoButton.interactable = true;
        }
    }

    public void ShowRewardedVideo()
    {
        Advertisement.Show(rewardedVideo);
        watchVideoButton.interactable = false;
        tryLater.SetActive(true);
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
       
        if (showResult == ShowResult.Finished)
        {
            moneyAmount += 10;
            PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
    
        }
        else if (showResult == ShowResult.Skipped)
        {
      
        }
        else if (showResult == ShowResult.Failed)
        {
            Debug.LogWarning("The ad did not finish due to an error.");
        }
    }

}
