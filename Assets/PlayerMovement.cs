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
        //basic wasd movement
        if(Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
            Debug.Log("Moved forward");
        }
        if(Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * speed * Time.deltaTime, Space.Self);
            Debug.Log("Moved left");
        }
        if(Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * speed * Time.deltaTime, Space.Self);
            Debug.Log("Moved back");
        }
        if(Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * speed * Time.deltaTime, Space.Self);
            Debug.Log("Moved right");
        }
        

    }

}
