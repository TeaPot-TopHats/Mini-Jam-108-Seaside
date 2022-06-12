using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployShark : MonoBehaviour
{

    public GameObject sharkPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(sharkWave());
    }

    private void spawnEnemy(){
        GameObject a = Instantiate(sharkPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x-10f, screenBounds.x+10f), Random.Range(-screenBounds.y-10f, screenBounds.y+10f));
    }

    IEnumerator sharkWave(){
        while(true){
            yield return new WaitForSeconds(Random.Range(respawnTime-6f, respawnTime+6f));
            spawnEnemy();
        }
    }
}
