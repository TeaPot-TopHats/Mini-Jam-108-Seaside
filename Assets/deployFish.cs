using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployFish : MonoBehaviour
{
    public GameObject fishPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(fishWave());
    }

    private void spawnEnemy(){
        GameObject a = Instantiate(fishPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), -5.8f);
    }

    IEnumerator fishWave(){
        while(true){
            yield return new WaitForSeconds(Random.Range(respawnTime-0.5f, respawnTime+0.5f));
            spawnEnemy();
        }
    }
    
}
