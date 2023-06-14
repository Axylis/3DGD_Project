using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinnersStage : MonoBehaviour
{
    public Button backButton;
    // Start is called before the first frame update
    void Start()
    {
        backButton.onClick.AddListener(backToMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void backToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
