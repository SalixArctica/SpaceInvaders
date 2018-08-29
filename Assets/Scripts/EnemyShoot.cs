using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour {
    private float timeSinceShot;
    public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
        timeSinceShot = 0;
	}
	
	// Update is called once per frame
	void Update () {
        timeSinceShot += Time.deltaTime;

        if(timeSinceShot > 3) {
            GameObject newBullet = GameObject.Instantiate(bulletPrefab, this.transform.position, new Quaternion());
            newBullet.GetComponent<BulletFly>().direction = new Vector2(0, -1);
            timeSinceShot = 0;
        }
		
	}
}
