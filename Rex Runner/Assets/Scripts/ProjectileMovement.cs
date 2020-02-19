using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    static private ProjectileMovement S;

    [Header("Set in Inspector")]
    public GameObject prefabBullet;
    public GameObject prefabCactus;
    public float velMult = 100f;

    void Awake()
    {
      
    }
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float randNum = Random.Range(0f, 1f);
        if(randNum <= 0.005)
        {
            GameObject projectile = Instantiate(prefabBullet) as GameObject;
            Rigidbody projRigidbody = projectile.GetComponent<Rigidbody>();
            Vector3 movement = new Vector3(5f, 0f, 0f);
            projRigidbody.AddForce(movement * -velMult);
        }
        else if (randNum <= 0.01)
        {
            GameObject projectile = Instantiate(prefabCactus) as GameObject;
            Rigidbody projRigidbody = projectile.GetComponent<Rigidbody>();
            Vector3 movement = new Vector3(3f, 0f, 0f);
            projRigidbody.AddForce(movement * -velMult);
        }
    }

}
