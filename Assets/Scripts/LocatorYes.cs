using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocatorYes : MonoBehaviour
{
    private int locatorAmount;

    public GameObject LocatorChoiceDisplay;

    public GameObject Locator;

    public Button yesButton;

    // Start is called before the first frame update
    void Start()
    {
        locatorAmount = PlayerPrefs.GetInt("LocatorAmount");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void YesClicked()
    {
        locatorAmount -= 1;
        PlayerPrefs.SetInt("LocatorAmount", locatorAmount);
        LocatorChoiceDisplay.SetActive(false);
        Locator.SetActive(true);

    }
}
