using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEnabler : MonoBehaviour
{

    public GameObject buttonDisabeler;

    public int buttonlvl;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("HighestLvl") >= buttonlvl)
        {
            buttonDisabeler.SetActive(false);
        }

        else if(PlayerPrefs.GetInt("HighestLvl") < buttonlvl)
        {
            buttonDisabeler.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
