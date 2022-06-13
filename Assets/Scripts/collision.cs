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
            SharedResources.IsGameOver = true;
        }
        else if (other.gameObject.CompareTag("Harpoon"))
        {
            Debug.Log("Hit detected for harpoon");
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            if (this.gameObject.CompareTag("Fishy"))
            {
                SharedResources.gold += 5;
            }
            else if (this.gameObject.CompareTag("Sami"))
            {
                SharedResources.gold += 10;
            }
        }
    }

}
