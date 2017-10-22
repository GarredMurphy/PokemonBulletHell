using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBullet : MonoBehaviour {  // i will probably add more kinds of bullets to the use Type Object pattern with this as the base


    public bool player;
    public Vector3 velocity;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

    private void FixedUpdate()
    {
        gameObject.transform.position += velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject hitobject = collision.gameObject;

        //need to program code for bullets to destroy themselves
        
    }
}

