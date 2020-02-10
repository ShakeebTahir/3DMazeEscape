using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocatorScript : MonoBehaviour
{

    private int locatorAmount;

    public GameObject LocatorChoiceDisplay;

    // Start is called before the first frame update
    void Start()
    {
        locatorAmount = PlayerPrefs.GetInt("LocatorAmount");
        if (locatorAmount >= 1)
        {
            LocatorChoiceDisplay.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
