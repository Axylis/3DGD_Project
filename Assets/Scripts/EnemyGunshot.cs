using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGunshot : MonoBehaviour
{
     private LineRenderer lr;
     [SerializeField] GameObject enemy;
    PlayerHealthSystem playerHealth;
    EnemyHealthSystem enemyHealth;
    private GameObject target;
    EnemyAI enemyAI;
    [SerializeField] int dmg;
    private float timeToNextShot = 1f;
    // Start is called before the first frame update
    void Start()
    {
        lr = this.GetComponent<LineRenderer>();
        enemyAI = this.GetComponent<EnemyAI>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(enemy.GetComponent<EnemyAI>().playerDetected == true)
        {
            timeToNextShot -= Time.deltaTime;
            if(timeToNextShot <= 0)
            {
                bulletShot();
                timeToNextShot = 1f;
            }         
        }
        else
        {
            timeToNextShot = 1f;
        }
    }

    void bulletShot()
    {
        //enables laser and sets start position
        lr.enabled = true;
        lr.SetPosition(0, this.transform.position);

        RaycastHit hitscan;
        //detects hits from raycast
        if(Physics.Raycast(this.transform.position, this.transform.forward, out hitscan))
        {
            if(hitscan.collider)
            {
                //sets end position on collision
                lr.SetPosition(1, hitscan.point);
                if(hitscan.collider.tag == "Player")
                {
                    Debug.Log("Player shot");
                    //references the enemy health system script of hit enemy
                    playerHealth = hitscan.transform.GetComponent<PlayerHealthSystem>();
                    if(playerHealth != null)
                    {
                        playerHealth.Damage(dmg);
                    }
                }
                StartCoroutine(DisableLasers());
            }
        }
        else
        {
            //sets end position 1000 units away from start
            lr.SetPosition(1, this.transform.forward*1000);
            StartCoroutine(DisableLasers());
        }
    }
    IEnumerator DisableLasers()
    {
        //disable bullet trail after 0.2 seconds
        yield return new WaitForSeconds(0.1f);
        lr.enabled = false;
    }
}
