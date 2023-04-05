using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthSystem : MonoBehaviour
{
    public float maxHP = 100;
    float currentHP;
    float damage;
    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        DeathCheck();
    }

    public void Damage(int damage)
    {
        currentHP -= damage;
    }

    void DeathCheck()
    {
        //checks if hp is 0 or below
        if(currentHP <= 0f)
        {
            Destroy(gameObject);
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
