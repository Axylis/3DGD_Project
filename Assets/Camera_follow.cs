using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_follow : MonoBehaviour
{
    public int cameraZoom = 15;
    Vector3 camPosition;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        //on game start, sets cam position to player
        camPosition = new Vector3(player.transform.position.x, player.transform.position.y + cameraZoom, player.transform.position.z);
        this.transform.position = camPosition;
    }

    // Update is called once per frame
    void Update()
    {
        //same as start but updates per frame
        camPosition = new Vector3(player.transform.position.x, player.transform.position.y + cameraZoom, player.transform.position.z);
        this.transform.position = camPosition;
    }
}
