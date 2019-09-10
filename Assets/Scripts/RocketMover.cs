using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class RocketMover : MonoBehaviour
{
    public float rocketSpeed;
    public GameObject rocket;

    public bool playerOne;
    
    public bool playerTwo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (playerOne)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.up * rocketSpeed * Time.deltaTime, Space.World);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.down * rocketSpeed * Time.deltaTime, Space.World);
            }
        }
        
        if (playerTwo)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector3.up * rocketSpeed * Time.deltaTime, Space.World);
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector3.down * rocketSpeed * Time.deltaTime, Space.World);
            }
        }

        
    }
}
