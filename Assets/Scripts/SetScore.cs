using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetScore : MonoBehaviour
{

    public Text pointsText;

    public void Setup(int score)
    {
        if (SharedResources.IsGameOver) { 

        gameObject.SetActive(true);
        pointsText.text = score.ToString() + "SHELLS";
        }
    }

    
   

}
