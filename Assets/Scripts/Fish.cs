using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{

    public float xSpeed = 5.0f;
    public float ySpeed = 1.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-xSpeed, ySpeed);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Assign monetary value of fish due to the depth at which it is found
    void assignValue()
    {


    }
    
    // Update is called once per frame
    void Update()
    {
        
        if(transform.position.x < -screenBounds.x)
        {
            rb.velocity = new Vector2(xSpeed,ySpeed);


        }
        else if(transform.position.x > screenBounds.x)
        {
            rb.velocity = new Vector2(-xSpeed,ySpeed);

        }
        else if(transform.position.y > screenBounds.y + (.5 * screenBounds.y))
        {
            Destroy(this.gameObject);
        }

        
    }
}
