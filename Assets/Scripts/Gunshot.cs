using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunshot : MonoBehaviour
{
    private LineRenderer lr;
    HealthSystem health;
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        lr = this.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lr.SetPosition(0, this.transform.position);

        RaycastHit hitscan;
        if(Physics.Raycast(this.transform.position, this.transform.forward, out hitscan))
        {
            if(hitscan.collider)
            {
                lr.SetPosition(1, hitscan.point);
            }
        }
        else
        {
            lr.SetPosition(1, this.transform.forward*1000);
        }

    }
}
