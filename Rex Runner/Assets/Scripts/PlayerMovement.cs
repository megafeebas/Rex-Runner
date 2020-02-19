using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  
    private Rigidbody rb;
    bool canJump;

    [Header("Set in Inspector")]
    public GameObject duck;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0) && canJump)
        {
            rb.velocity = new Vector3(0, 5f, 0);
            canJump = false;
        }
        if (Input.GetMouseButtonDown(1) && canJump)
        {
            gameObject.SetActive(false);
            duck.SetActive(true);
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
            print("Hit");
            Destroy(gameObject);
            GameObject[] tProjectileArray = GameObject.FindGameObjectsWithTag("Projectile");
            foreach (GameObject tGO in tProjectileArray)
            {
                Destroy(tGO);
            }
            Application.Quit();
        }
    }
}
