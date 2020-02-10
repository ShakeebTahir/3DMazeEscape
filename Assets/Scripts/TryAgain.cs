using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{
    public Button tryAgain;

    public GameObject lostScreen;

    public GameObject currentLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TryAgainClicked()
    {
        lostScreen.SetActive(false);
        SceneManager.LoadScene(currentLevel.name);
    }
}
