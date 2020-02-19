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
            print("okay");
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {
        print("mhm");
        yield return new WaitForSeconds(1);
        gameObject.SetActive(false);
        player.SetActive(true);
    }
}
