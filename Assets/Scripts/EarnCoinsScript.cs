using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarnCoinsScript : MonoBehaviour
{
    private int moneyAmount;

    public Text moneyAmountText;

    public Button videoButton;

    void Start()
    {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
    }

    void Update()
    {
        moneyAmountText.text = " " + moneyAmount.ToString();
    }

    public void WatchVideo()
    {
        moneyAmount += 10;
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
    }

}
