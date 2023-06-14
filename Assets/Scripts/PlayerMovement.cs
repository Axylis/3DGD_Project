using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{    
    public AudioSource audioSource;
    public float speed = 7f;
    public Animator animator;
    bool soundPlaying;

    public GameObject player;

    void Awake()
    {
        player.SetActive(true);
    }
    void Start()
    {
        player.SetActive(true);
        Time.timeScale = 1;
    }
    void Update() {  
        //basic wasd movements
        if(Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
            animator.SetBool("stat_walk", true);
            if(soundPlaying != true)
            {
                audioSource.Play();
                soundPlaying = true;
            }   
        }
        if(Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
            animator.SetBool("stat_walk", true);
            if(soundPlaying != true)
            {
                audioSource.Play();
                soundPlaying = true;
            } 
        }
        if(Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * speed * Time.deltaTime, Space.World);
            animator.SetBool("stat_walk", true);
            if(soundPlaying != true)
            {
                audioSource.Play();
                soundPlaying = true;
            } 
        }
        if(Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
            animator.SetBool("stat_walk", true);
            if(soundPlaying != true)
            {
                audioSource.Play();
                soundPlaying = true;
            } 
        }
        if(Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("stat_walk", false);
            audioSource.Stop();
            soundPlaying = false;
        }
        if(Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("stat_walk", false);
            audioSource.Stop();
            soundPlaying = false;
        }
        if(Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("stat_walk", false);
            audioSource.Stop();
            soundPlaying = false;
        }
        if(Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("stat_walk", false);
            audioSource.Stop();
            soundPlaying = false;
        }
        Debug.Log("Pos: " + this.transform.position);
    }

}
