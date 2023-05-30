using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{    
    float speed = 5f;

    void Start()
    {
        
    }
    void Update() {
        //basic wasd movements
        if(Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
            //this.GetComponent<Animator>().SetBool("stat_jalan", true);
        }
        if(Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
            //this.GetComponent<Animator>().SetBool("stat_jalan", true);
        }
        if(Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * speed * Time.deltaTime, Space.World);
            //this.GetComponent<Animator>().SetBool("stat_jalan", true);
        }
        if(Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
           // this.GetComponent<Animator>().SetBool("stat_jalan", true);
        }
        
        Debug.Log("Pos: " + this.transform.position);
    }

}
