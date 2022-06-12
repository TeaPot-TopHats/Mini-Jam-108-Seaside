using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    public GameObject fishPrefab;

    public Transform player;
    public float speed = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
    }

    void movePlayer(Vector2 direction)
    {
        player.Translate(direction*speed*Time.deltaTime);
    }

    // Cant figure out collision with destroying player
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(player);
        }
    }
}
