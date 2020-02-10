using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PausedOptions : MonoBehaviour
{

    public Button resume;

    public Button quit;

    public GameObject PauseChoiceScreen;

    public void Resume()
    {
        AudioListener.pause = false;
        Time.timeScale = 1;
        PauseChoiceScreen.SetActive(false);
    }

    public void Quit()
    {
        AudioListener.pause = false;
        Time.timeScale = 1;
        SceneManager.LoadScene("Level Select");
    }
}
