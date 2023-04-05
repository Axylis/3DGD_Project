using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    //general behaviour enemy AI
    [SerializeField] GameObject detectionRange;
    public float walkSpeed = 10f;
    private bool playerDetected = false;
    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerDetected == true)
        {
            this.transform.LookAt(player.transform.position);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            playerDetected = true;
        }
        else
        {
            playerDetected = false;
        }
    }

}
