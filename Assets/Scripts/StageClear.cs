using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageClear : MonoBehaviour
{
    public GameObject clearButton, clear_text, player;
    public EnemyCounter enemyCounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Continue()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyCounter.stageClear == true)
        {
            player.SetActive(false);
            Time.timeScale = 0f;
            clearButton.SetActive(true);
            clear_text.SetActive(true);
        }
    }
}
