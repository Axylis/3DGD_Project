using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthSystem : MonoBehaviour
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

    public void Damage(float damage)
    {
        currentHP -= damage;
        Debug.Log("HP : " + currentHP);
    }

    void DeathCheck()
    {
        //checks if hp is 0 or below
        if(currentHP <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
