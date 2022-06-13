using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    public float mapSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position = new Vector2(this.transform.position.x, this.transform.position.y + mapSpeed * 1 / 4 * SharedResources.anchorLevel);
        if(SharedResources.count == true)
        {
            SharedResources.depth = this.transform.position.y;

        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            mapSpeed = 0;
            SharedResources.IsGameOver = true;
        }

    }

}
