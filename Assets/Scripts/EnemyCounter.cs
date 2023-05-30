using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyCounter : MonoBehaviour
{
    public TMP_Text enemyCounter;
    GameObject[] enemy;
    // Start is called before the first frame update
    void Start()
    {
        //finds game object with enemy tag
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        //displays number of enemies in text
        enemyCounter.text = "Enemy Left: " + enemy.Length;
    }
}
