using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{

    public GameObject PauseChoiceScreen;

    public void PauseGame()
    {
        AudioListener.pause = true;
        Time.timeScale = 0;
        PauseChoiceScreen.SetActive(true);
    }
}
