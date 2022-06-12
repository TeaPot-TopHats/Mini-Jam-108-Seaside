using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class direction : MonoBehaviour
{
    float xCurr;
    float speed;
    SpriteRenderer al;

    // Start is called before the first frame update
    void Start()
    {
        xCurr=transform.position.x;
        al = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = transform.position.x-xCurr;
        xCurr = transform.position.x;

        if (speed > 0) // Moving to right
        {

            al.flipX=true;
        }
        else if(speed < 0)
        {
            al.flipX=false;
        }
    }
}
