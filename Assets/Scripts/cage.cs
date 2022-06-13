using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cage : MonoBehaviour
{
    public float speed;
    private Vector2 targetPosition;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
        SharedResources.count = false;
        targetPosition = target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(!this.transform.position.Equals(targetPosition))
        {
            this.transform.position = Vector2.MoveTowards(this.transform.position, targetPosition, speed * Time.deltaTime);
            SharedResources.count = false;
        }
        else if (this.transform.position.Equals(targetPosition))
        {
            SharedResources.count = true;
        }
        
    }

}
