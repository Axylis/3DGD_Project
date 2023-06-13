using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPickup : MonoBehaviour
{
    public GunInventory gunInventory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.gameObject.transform.Rotate(0f,1f,0f, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(this.tag == "FullAutoRifle" && other.tag == "Player")
        {
            gunInventory.weapon2Acquired = true;
            Destroy(this.gameObject);
        }
        if(this.tag == "SniperRifle" && other.tag == "Player")
        {
            gunInventory.weapon3Acquired = true;
            Destroy(this.gameObject);
        }
    }
}
