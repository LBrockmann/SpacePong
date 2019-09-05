using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class respawnScript : MonoBehaviour
{
    public Transform respawnPoint1;
    public int score;
    public GameObject rocket;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();  
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        score = score + 1;
        Debug.Log(score);
       rocket.transform.position = respawnPoint1.position;
        Debug.Log("respawn");
        
    }
}
