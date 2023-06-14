using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AmmoCounter : MonoBehaviour
{
    public AmmoSystem[] ammoSystem;
    public TMP_Text ammocount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ammoSystem[0].isActiveAndEnabled)
        {
            ammocount.text = ammoSystem[0].currentAmmo + "/" + ammoSystem[0].reserveAmmo;
        }
        if(ammoSystem[1].isActiveAndEnabled)
        {
            ammocount.text = ammoSystem[1].currentAmmo + "/" + ammoSystem[1].reserveAmmo;
        }
        if(ammoSystem[2].isActiveAndEnabled)
        {
            ammocount.text = ammoSystem[2].currentAmmo + "/" + ammoSystem[2].reserveAmmo;
        }
        
    }
}
