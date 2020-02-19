using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  
    private Rigidbody rb;
    public float speed;
    bool mouseDown = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (mouseDown)
        {
            Vector3 movement = new Vector3(0, 1.0f, 0);
            print(Random.Range(0f,10f));
            rb.AddForce(movement * speed);
        }
    }

    void OnMouseDown()
    {
        mouseDown = true;
    }
}
