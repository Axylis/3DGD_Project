using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthSystem : MonoBehaviour
{
    public Text HPcounter;
    public float maxHP = 100;
    public float currentHP;
    float damage;

    // Start is called before the first frame update
    void Start()
    {
        HPcounter.text = "Player HP:" + currentHP;
        currentHP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        DeathCheck();
    }

    public void Damage(float damage)
    {
        currentHP -= damage;
    }

    void DeathCheck()
    {
        //checks if hp is 0 or below
        if(currentHP <= 0f)
        {
            this.gameObject.SetActive(false);
        }
    }

    public void Heal(float healAmount)
    {
        if((currentHP += healAmount) <= maxHP)
        {
            currentHP += healAmount;
        }
        else
        {
            currentHP = maxHP;
        }
    }

}
