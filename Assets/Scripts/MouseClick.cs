using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    public GameObject mouse;
    private Vector3 point;
    public GameObject player;
    public GameObject bulletPrefab;
    public GameObject bulletStart;

    public float bulletSpeed;
    public float reloadSpeed;
    private float timePassed;
    private bool fireReady;
    

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        point = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        mouse.transform.position = new Vector2(point.x, point.y);

        Vector3 difference = point - player.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        player.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        Debug.Log("time passed: " + timePassed + " and reload speed: " + reloadSpeed);
        if (Input.GetMouseButtonDown(0) && timePassed > reloadSpeed * (1/SharedResources.harpoonLevel))
        {
            Debug.Log("Clicked");
            float distance = difference.magnitude;
            Vector2 direction = difference / distance;
            direction.Normalize();
            FireBullet(direction, rotationZ);
            Debug.Log("worked");
            timePassed = 0;
        }

        timePassed += Time.deltaTime;


        

    }

    void FireBullet(Vector2 direction, float rotationZ)
    {
        
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = bulletStart.transform.position;
        b.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        b.GetComponent<Rigidbody2D>().velocity = direction * (bulletSpeed * (.5f * SharedResources.harpoonLevel));
    }
}
