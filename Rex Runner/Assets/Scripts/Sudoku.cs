using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sudoku : MonoBehaviour
{

    // Start is called before the first frame update
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.x < -12)
        {
            Destroy(gameObject);
        }
    }
}
