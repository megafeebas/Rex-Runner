using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    static private ProjectileMovement S;

    public GameObject projectile;
    public GameObject prefabProjectile;
    private Rigidbody projectileRigidbody;
    public Vector3 launchPos;
    public float velocity = 5f;

    void Awake()
    {
        Transform launchPoint = transform.Find("Shooter");
        launchPos = launchPoint.position;
        projectileRigidbody = projectile.GetComponent<Rigidbody>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float randNum = Random.Range(0f, 1f);
        if(randNum < .1)
        {
            projectile = Instantiate(prefabProjectile);
            projectile.transform.position = launchPos;
            projectile.velocity = new Vector3(0f, 5f, 0f);
        }
    }
}
