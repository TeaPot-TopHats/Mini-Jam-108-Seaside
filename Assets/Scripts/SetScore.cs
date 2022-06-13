using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetScore : MonoBehaviour
{
    public static SetScore instance;
    public Text pointsText;
    int score = 0;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        pointsText.text = score.ToString() + "SHEELS";
    }

    public void AddPoints()
    {
        score += 5;
        pointsText.text = score.ToString() + "SHEELS";

        PlayerPrefs.SetInt("SHEELS", score);
    }
    public void AddPoints2()
    {
        score += 10;
        pointsText.text = score.ToString() + "SHEELS";
        PlayerPrefs.SetInt("SHEELS", score);
    }



}
