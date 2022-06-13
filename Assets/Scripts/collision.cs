using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Player")){
            Debug.Log("Hit detected for player");
            Destroy(other.gameObject);
            Debug.Log(true);
            SceneManager.LoadScene("GameOverScene");
            Debug.Log(true);
        }
        else if (other.gameObject.CompareTag("Harpoon"))
        {
            Debug.Log("Hit detected for harpoon");
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            if (this.gameObject.CompareTag("Fishy"))
            {
                SetScore.instance.AddPoints();
            }
            else if (this.gameObject.CompareTag("Sami"))
            {
                SetScore.instance.AddPoints2();
            }
        }
    }

}
