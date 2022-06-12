using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")){
            Debug.Log("Hit detected for player");
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Harpoon"))
        {
            Debug.Log("Hit detected for harpoon");
            Destroy(other.gameObject);
            Destroy(this.gameObject);

        }
    }

}
