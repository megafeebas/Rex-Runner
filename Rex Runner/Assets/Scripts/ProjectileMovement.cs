using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjectileMovement : MonoBehaviour
{
    static private ProjectileMovement S;


    [Header("Set in Inspector")]
    public GameObject prefabBullet;
    public GameObject prefabCactus;
    public Text Score;
    public Text HighScore;
    int score;
    public float velMult = 100f;

    void Awake()
    {
        GameObject scoreGO = GameObject.Find("Score");
        Score = scoreGO.GetComponent<Text>();
        Score.text = "Score: 0";
    }
    void Start()
    {
        score = 0;
    }

    void Update()
    {
        score++;
        Score.text = "Score: " + score;
        int hScore = int.Parse(HighScore.text.Substring(12));
        if (score > hScore)
        {
            hScore = score;
            HighScore.text = "High Score: " + hScore;
        }
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
