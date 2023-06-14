using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AmmoSystem : MonoBehaviour
{
    public int currentAmmo, reserveAmmo, magLimit;
    public GunInventory gunInventory;
    public Gunshot gunshot;
    public TMP_Text ammoCount;
    // Start is called before the first frame update
    void Start()
    {       
        
    }

    // Update is called once per frame
    void Update()
    {
        ammoCount.text = currentAmmo + "/" + reserveAmmo;
        if(Input.GetKeyDown(KeyCode.R) && currentAmmo < magLimit && reserveAmmo > 0)
        {
            StartCoroutine(reloadDelay());
        }

    }

    IEnumerator reloadDelay()
    {
        int bulletsToAdd = magLimit - currentAmmo;
        if(reserveAmmo >= bulletsToAdd)
        {
            yield return new WaitForSecondsRealtime(2);
            currentAmmo += bulletsToAdd;
            reserveAmmo -= bulletsToAdd;
        }
        else if(reserveAmmo < bulletsToAdd)
        {
            yield return new WaitForSecondsRealtime(2);
            currentAmmo += reserveAmmo;
            reserveAmmo = 0;
        }
        
    }

}
