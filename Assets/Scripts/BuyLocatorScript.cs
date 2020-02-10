using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyLocatorScript : MonoBehaviour
{

    private int locatorAmount;

    private int moneyAmount;

    public Text locatorAmountText;

    public Text moneyAmountText;

    public Button buyButton;

    // Start is called before the first frame update
    void Start()
    {
        locatorAmount = PlayerPrefs.GetInt("LocatorAmount");
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");

        if(moneyAmount < 100)
        {
            buyButton.interactable = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        locatorAmountText.text = " " + locatorAmount.ToString();
        moneyAmountText.text = " " + moneyAmount.ToString();
        if(moneyAmount < 100)
        {
            buyButton.interactable = false;
        }
    }

    public void BuyButtonClicked()
    {
        locatorAmount += 1;
        moneyAmount -= 100;
        PlayerPrefs.SetInt("LocatorAmount", locatorAmount);
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
    }

}
