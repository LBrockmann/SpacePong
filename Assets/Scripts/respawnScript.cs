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

    public GameObject ball;

    private float randomy;

    private float coinFlip;

    private float ballVelocityside;

    private float timer;

    public float timerCap;

    private bool ballMove;

    private bool startTimer;
    // Start is called befor
    // e the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();  
        randomy = Random.Range(-10f, 10f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player1") || other.gameObject.CompareTag("Player2"))
        {
            score = score + 1;
            Debug.Log("score 1");
            Debug.Log(score);
            rocket.transform.position = respawnPoint1.position;
            Debug.Log("respawn");
        }

        if (other.gameObject.CompareTag("ball"))
        {
            ballMove = false;
            score = score + 2;
         
            ball.transform.position = new Vector3(-0.31f,-1.95f,0f);
            ballVelocityside = 60f;
            ball.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
            timer = timer + 1 * Time.deltaTime;
            if (timerCap <= timer && ballMove == false)
            {
                
            }
            
            coinFlip = Random.Range(0, 2)*2f-1f;
            
            if (coinFlip >= 0)
            {
                ballVelocityside = ballVelocityside;
                Debug.Log("tails");    
            }

            else if (coinFlip < 0)
            {
          
           
                ballVelocityside = ballVelocityside - (ballVelocityside*2f);
                Debug.Log("heads");
            }


            ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(ballVelocityside,randomy));
        }
            //ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(100f, randomy));
            //ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(ballVelocityside, randomy));
    }

        
    }

