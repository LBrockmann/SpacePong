using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public float bulletSpeed;
    public float resetPoint;
    public bool moveLeft;
    public GameObject player1;
    public GameObject player2;
    public Transform p1Respawn;
    public Transform p2Respawn;
    private float randomy;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        randomy = Random.Range(-4.2f, 4.2f);
        if (moveLeft == false)
        {
            transform.Translate((Vector3.right * bulletSpeed * Time.deltaTime));

            if (transform.position.x > 8.9)
            {
                transform.position = new Vector3(-8.9f, randomy, transform.position.z);
            }
        }

        if (moveLeft)
        {
            transform.Translate((Vector3.left * bulletSpeed * Time.deltaTime)); 
            if (transform.position.x < -8.9f)
            {
                transform.position = new Vector3(8.9f, randomy, transform.position.z);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            player1.transform.position = p1Respawn.position;
        }
        if (other.gameObject.CompareTag("Player2"))
        {
            player2.transform.position = p2Respawn.position;
        }
    }
}
