using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyCounter : MonoBehaviour
{
    public TMP_Text enemyCounter;
    public GameObject clear_text, clearButton;
    public GameObject[] enemy;
    public bool stageClear = false;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //finds game object with enemy tag
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        //displays number of enemies in text
        enemyCounter.text = "Enemy Left: " + enemy.Length;
        if(enemy.Length == 0)
        {
            stageClear = true;
        }
    }
}
