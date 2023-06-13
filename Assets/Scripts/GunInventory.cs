using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunInventory : MonoBehaviour
{
    public GameObject[] guns;
    public bool weapon2Acquired = false;
    public bool weapon3Acquired = false;
    // Start is called before the first frame update
    void Start()
    {
        //gun 0 is semi auto rifle, gun 2 is full auto rifle, and gun 3 is sniper

        DontDestroyOnLoad(guns[0]);
        DontDestroyOnLoad(guns[1]);
        DontDestroyOnLoad(guns[2]);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            //activates only gun 1
            guns[0].SetActive(true);
            guns[1].SetActive(false);
            guns[2].SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2) && weapon2Acquired == true)
        {
            //activates only gun 2
            guns[0].SetActive(false);
            guns[1].SetActive(true);
            guns[2].SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.Alpha3) && weapon3Acquired == true)
        {
            //activates only gun 3
            guns[0].SetActive(false);
            guns[1].SetActive(false);
            guns[2].SetActive(true);
        }
        

    }


}
