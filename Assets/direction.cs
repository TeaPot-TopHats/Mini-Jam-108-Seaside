using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class direction : MonoBehaviour
{
    float xCurr;
    float Speed;
    SpriteRenderer al;

    // Start is called before the first frame update
    void Start()
    {
        xCurr=transform.position.x;
        al = gameObject.getComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Speed = transform.position.x-xCurr;
        xCurr = transform.position.x;

        if (Speed > 0) // Moving to right
        {
            al.flipX=true;
        }
        else 
        {
            al.flipX=false;
        }
    }
}
