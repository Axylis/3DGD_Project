using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPIndicator : MonoBehaviour
{
    public Text HpIndicator;
    public GameObject player;
    PlayerHealthSystem playerHealthSystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HpIndicator.text = "Player HP: " + player.GetComponent<PlayerHealthSystem>().currentHP;
    }
}
