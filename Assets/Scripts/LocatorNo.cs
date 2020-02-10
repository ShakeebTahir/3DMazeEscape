using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocatorNo : MonoBehaviour
{
    public GameObject LocatorChoiceDisplay;

    public Button noButton;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NoClicked()
    {
        LocatorChoiceDisplay.SetActive(false);
    }
}
