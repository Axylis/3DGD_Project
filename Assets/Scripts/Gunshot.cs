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
    public GunInventory gunInventory;
    bool canShoot;
    public AmmoSystem[] ammo;


    // Start is called before the first frame update
    void Start()
    {
        lr = this.GetComponent<LineRenderer>();
        DontDestroyOnLoad(gunInventory);
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(gunInventory.guns[0].activeInHierarchy == true)
        {
            //click left mouse button to shoot
            if(Input.GetKeyDown(KeyCode.Mouse0) && ammo[0].currentAmmo > 0)
            {
                bulletShot();
                ammo[0].currentAmmo--;
            }
        }
        
        if(gunInventory.guns[2].activeInHierarchy == true && canShoot && ammo[2].currentAmmo > 0)
        {
            //click left mouse button to shoot
            if(Input.GetKeyDown(KeyCode.Mouse0))
            {
                StartCoroutine(SR_ROFLimiter());
                ammo[2].currentAmmo--;
            }
        }
        
    }

    void FixedUpdate()
    {
        if(gunInventory.guns[1].activeInHierarchy == true && canShoot && ammo[1].currentAmmo > 0)
        {
            //click left mouse button to shoot
            if(Input.GetKey(KeyCode.Mouse0))
            {
                StartCoroutine(ROFLimiter());
                ammo[1].currentAmmo--;
            }
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
                    if(enemyHealth != null && gunInventory.guns[0].activeInHierarchy == true)
                    {
                        enemyHealth.Damage(25f);
                    }
                    else if(enemyHealth != null && gunInventory.guns[1].activeInHierarchy == true)
                    {
                        enemyHealth.Damage(10f);
                    }
                    else if(enemyHealth != null && gunInventory.guns[2].activeInHierarchy == true)
                    {
                        enemyHealth.Damage(100f);
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

    IEnumerator ROFLimiter()
    {
        canShoot = false;
        bulletShot();
        yield return new WaitForSecondsRealtime(0.06f);
        canShoot = true;
    }
    IEnumerator SR_ROFLimiter()
    {
        canShoot = false;
        bulletShot();
        yield return new WaitForSecondsRealtime(1f);
        canShoot = true;
    }
    
}
