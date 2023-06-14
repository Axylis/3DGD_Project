using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageClear : MonoBehaviour
{
    public GameObject clearButton, clear_text, player, cover;
    public EnemyCounter enemyCounter;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    public void Continue()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        player.SetActive(true);
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyCounter.stageClear == true)
        {
            cover.SetActive(true);
            clearButton.SetActive(true);
            clear_text.SetActive(true);
        }
    }
}
