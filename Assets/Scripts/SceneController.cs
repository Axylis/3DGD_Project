using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    Scene scene;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        player = GameObject.FindGameObjectWithTag("Player");
        if(scene.buildIndex == 2)
        {
            player.transform.position = new Vector3(-7.051185f, -2.172067f, 8.06f);
            player.SetActive(true);
            Time.timeScale = 1;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
