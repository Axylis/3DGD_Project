using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverText, cover;

    public PlayerHealthSystem playerHealthSystem;
    public Button retry;
    // Start is called before the first frame update
    void Start()
    {
        retry.onClick.AddListener(returnToBeginning);
    }

    public void returnToBeginning()
    {
        SceneManager.LoadScene("LEVEL MAP 1 UTS SHOOTER");
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHealthSystem.currentHP <= 0)
        {
            cover.SetActive(true);
            gameOverText.SetActive(true);
            retry.gameObject.SetActive(true);
        }
    }
}
