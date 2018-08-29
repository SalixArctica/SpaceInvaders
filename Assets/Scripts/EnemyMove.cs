using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    private float timeSinceLastMove;
    private Transform EnemyTransform;
    private Vector2 direction;

	// Use this for initialization
	void Start () {
        timeSinceLastMove = 0;
        EnemyTransform = GetComponent<Transform>();
        direction = new Vector2(1, 0);
	}
	
	// Update is called once per frame
	void Update () {
        timeSinceLastMove += Time.deltaTime;

        if(timeSinceLastMove > 2) {

            if (EnemyTransform.position.x == 10 || EnemyTransform.position.x == -10) {
                direction *= -1;
                EnemyTransform.Translate(new Vector2(0, -0.5f));
            }

            timeSinceLastMove = 0;
            EnemyTransform.Translate(direction);
        }

	}
}

