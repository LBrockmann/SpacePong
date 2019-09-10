using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovementScriot : MonoBehaviour
{

    public GameObject player1;

    public GameObject player2;

    public GameObject ball;

    public Rigidbody2D rigbod;

    public float ballVelocityup;

    public float ballVelocityside;

    public float coinFlip;
    // Start is called before the first frame update
    void Start()
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
       
        ballVelocityup = 200f;
        rigbod.AddForce(new Vector2(ballVelocityside,0));
    }

    // Update is called once per frame
    void Update()
    {

    }

  
}
