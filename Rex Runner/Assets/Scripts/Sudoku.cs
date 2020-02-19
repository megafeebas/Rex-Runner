using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sudoku : MonoBehaviour
{
    bool counted = false;
    public Text Score;
    public Text HighScore;

    // Start is called before the first frame update
    void Start()
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
