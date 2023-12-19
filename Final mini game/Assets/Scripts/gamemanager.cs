using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class gamemanager : MonoBehaviour
{
    public bool isGameActive = false;

    public Button replayButton;

    public Button startButton;

    public GameObject coinText;
    // Start is called before the first frame update
    void Start()
    {
        replayButton.gameObject.SetActive(false);
        startButton.gameObject.SetActive(true);
        coinText.SetActive(false);
    }



    public void GameOver()
    {
        isGameActive = false;
        replayButton.gameObject.SetActive(true);
    }

    public void pressreplayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void pressstartbutton()
    {
        isGameActive = true;
        coinText.SetActive(true);
        startButton.gameObject.SetActive(false);
    }
}
