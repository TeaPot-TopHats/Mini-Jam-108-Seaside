using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -screenBounds.x + (.5 * -screenBounds.x) 
            | transform.position.x > screenBounds.x + (.5 * screenBounds.x) 
            | transform.position.y < -screenBounds.y + (.5 * -screenBounds.y) 
            | transform.position.y > screenBounds.y + (.5 * screenBounds.y))
        {
            Destroy(this.gameObject);
        }
    }
}
