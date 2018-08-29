using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    private Vector2 moveHorizontal;
    

    // Use this for initialization
    void Start () {
        
        
	}
	
	// Update is called once per frame
	void Update () {


        moveHorizontal = Input.GetAxis("Horizontal") * new Vector2(1, 0);
        this.transform.Translate(moveHorizontal * Time.deltaTime * speed);


       

    }

    private void FixedUpdate() { 
    
        
       


    }
}
