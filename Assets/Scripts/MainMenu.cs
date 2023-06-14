using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button startGame, controls, backButton;
    public TMP_Text gameControls;
    public AudioSource audioClick;
    // Start is called before the first frame update
    void Start()
    {
        startGame.onClick.AddListener(changeScene);
        controls.onClick.AddListener(helpMenu);
        backButton.onClick.AddListener(returnToMain);
    }

    void changeScene()
    {
        audioClick.Play();
        SceneManager.LoadScene(1);
    }

    void helpMenu()
    {
        audioClick.Play();
        startGame.gameObject.SetActive(false);
        controls.gameObject.SetActive(false);
        gameControls.gameObject.SetActive(true);
        backButton.gameObject.SetActive(true);
    }
    void returnToMain()
    {
        audioClick.Play();
        startGame.gameObject.SetActive(true);
        controls.gameObject.SetActive(true);
        gameControls.gameObject.SetActive(false);
        backButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
