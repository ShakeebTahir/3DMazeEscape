using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayLocatorAmount : MonoBehaviour
{

    private int locatorAmount;

    public Text locatorAmountText;

    // Start is called before the first frame update
    void Start()
    {
        locatorAmount = PlayerPrefs.GetInt("LocatorAmount");
    }

    // Update is called once per frame
    void Update()
    {
        locatorAmountText.text = " " + locatorAmount.ToString();
    }
}
