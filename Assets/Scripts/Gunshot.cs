using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunshot : MonoBehaviour
{
    private LineRenderer lr;
    PlayerHealthSystem playerHealth;
    EnemyHealthSystem enemyHealth;
    private GameObject target;
    [SerializeField] int dmg;
    // Start is called before the first frame update
    void Start()
    {
        lr = this.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //click left mouse button to shoot
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            bulletShot();
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
                if(hitscan.collider.tag == "Enemy")
                {
                    Debug.Log("Enemy shot");
                    //references the enemy health system script of hit enemy
                    enemyHealth = hitscan.transform.GetComponent<EnemyHealthSystem>();
                    if(enemyHealth != null)
                    {
                        enemyHealth.Damage(25f);
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
        yield return new WaitForSeconds(0.2f);
        lr.enabled = false;
    }
}
