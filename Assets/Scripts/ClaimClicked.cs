using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClaimClicked : MonoBehaviour
{
    private int moneyAmount;

    public GameObject EndScreen;

    public GameObject selectScreen;

    public Button Claim;

    // Start is called before the first frame update
    void Start()
    {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
    }


    public void ClaimButtonClicked()
    {
        moneyAmount += 10;
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        EndScreen.SetActive(false);
        SceneManager.LoadScene(selectScreen.name);
    }

}
