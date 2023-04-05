using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour
{
    PlayerHealthSystem playerHealth;
    public float healthRestore;

    void OnTriggerEnter(Collider collider)
    {
        playerHealth.Heal(50f);
    }
}
