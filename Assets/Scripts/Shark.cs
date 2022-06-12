using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : MonoBehaviour
{

    public float speed = 2.0f;
    private Rigidbody2D rb;
    private Vector2 targetPosition;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        targetPosition = target.transform.position;
    }

    // Assign monetary value of fish due to the depth at which it is found
    void assignValue()
    {


    }

    // Update is called once per frame
    void Update()
    {
       this.transform.position = Vector2.MoveTowards(this.transform.position, targetPosition, speed * Time.deltaTime);
       
    }

    
}
