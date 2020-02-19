using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;

    void Awake()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.active)
        {
            StartCoroutine(Wait());
        }

    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(.5f);
        gameObject.SetActive(false);
        player.SetActive(true);
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
        }
    }
}
