using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour
{
    [SerializeField] GameObject player;
    PlayerHealthSystem playerHealth;
    public float healthRestore = 50f;

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            player.GetComponent<PlayerHealthSystem>().Heal(healthRestore);
            Destroy(gameObject);
        }  
    }

    void FixedUpdate()
    {
        this.gameObject.transform.Rotate(0f,1f,0f, Space.World);
    }
}
