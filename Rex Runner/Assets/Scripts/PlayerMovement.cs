using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  
    private Rigidbody rb;
    bool canJump;
    GameObject player;
    GameObject duck;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0) && canJump)
        {
            rb.velocity = new Vector3(0, 5f, 0);
            canJump = false;
        }
        if (Input.GetMouseButtonDown(1) && canJump)
        {
            print("Here");
            player.SetActive(false);
            //duck.SetActive(true);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            canJump = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Projectile"))
        {
            Destroy(gameObject);
        }
    }
}
