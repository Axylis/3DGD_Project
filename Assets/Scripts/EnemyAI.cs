using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    //general behaviour enemy AI
    [SerializeField] GameObject detectionRange;
    public float walkSpeed = 10f;
    public bool playerDetected = false;
    [SerializeField] GameObject player;

    public Animator animator;

    private float step;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        step = walkSpeed * Time.deltaTime/10;
        //rotates and moves towards players in area
        if(playerDetected == true)
        {
            this.transform.LookAt(player.transform.position);
            this.transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, step);
            animator.SetBool("stat_jalan", true);
        }
        else
        {
            animator.SetBool("stat_jalan", false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //triggers when player is detected
        if(other.gameObject.tag == "Player")
        {
            playerDetected = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //triggers when player is detected
        if(other.gameObject.tag == "Player")
        {
            playerDetected = false;
        }
    }

}
