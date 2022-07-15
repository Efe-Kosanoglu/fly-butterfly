using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawn;

    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetButton("Jump"))
        {
            rb.AddForce(transform.up *2);
        }

        if(Input.GetKey("d"))
        {
            rb.AddForce(transform.right *-1f);
        } 

        if(Input.GetKey("a"))
        {
            rb.AddForce(transform.right *1f);
        }  

        if(Input.GetKey("r"))
        {
            player.transform.position = respawn.transform.position;
        } 
            
    } 

}
