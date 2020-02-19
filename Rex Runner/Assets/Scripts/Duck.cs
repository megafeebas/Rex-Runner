using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.active)
        {
            Wait();

        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        gameObject.SetActive(false);
    }
}
