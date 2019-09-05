using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public float bulletSpeed;
    public float resetPoint;
    public bool moveLeft;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveLeft == false)
        {
            transform.Translate((Vector3.right * bulletSpeed * Time.deltaTime));

            if (transform.position.x > 6.8f)
            {
                transform.position = new Vector3(-7.15f, transform.position.y, transform.position.z);
            }
        }

        if (moveLeft)
        {
            transform.Translate((Vector3.left * bulletSpeed * Time.deltaTime)); 
            if (transform.position.x < -7.15f)
            {
                transform.position = new Vector3(6.8f, transform.position.y, transform.position.z);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            
        }
        if (other.gameObject.CompareTag("Player2"))
        {
            
        }
    }
}
