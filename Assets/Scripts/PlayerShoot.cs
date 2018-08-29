using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GameObject newBullet = GameObject.Instantiate(bulletPrefab, this.transform.position, new Quaternion());
            newBullet.GetComponent<BulletFly>().direction = new Vector2(0, 10);
        }

    }
}
