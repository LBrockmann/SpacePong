using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovementScriot : MonoBehaviour
{

    public GameObject player1;

    public GameObject player2;

    public GameObject ball;

    public Rigidbody2D rigbod;

    private float speed;

    public float ballVelocityside;

    public float coinFlip;

    private float randomy;

    private float timer;
    public float timerCap;
    private bool ballMove;
    // Start is called before the first frame update
    void Start()
    {
        
        //speed = 1;

       
    }

    // Update is called once per frame
    void Update()
    {
        //rigbod.velocity = Vector2.ClampMagnitude(rigbod.velocity, -speed);
        //rigbod.velocity = rigbod.velocity.normalized * speed;
        randomy = Random.Range(-10f, 10f);
        timer = timer + 1 * Time.deltaTime;

        if (timerCap <= timer && ballMove == false)
        {
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
       
        
            rigbod.AddForce(new Vector2(ballVelocityside,randomy));
            ballMove = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //rigbod.AddForce(new Vector2(50f,0));
    }
}
