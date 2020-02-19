using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    [Header("Set in Inspector")]
    public GameObject duck;

    private Rigidbody rb;
    bool canJump;

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
            Destroy(gameObject);
            GameObject[] tProjectileArray = GameObject.FindGameObjectsWithTag("Projectile");
            foreach (GameObject tGO in tProjectileArray)
            {
                Destroy(tGO);
            }
            StartCoroutine(Wait());
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
    }
}
