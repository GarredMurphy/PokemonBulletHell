using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPokemon : MonoBehaviour { // I am using type object for pokemon

    // Use this for initialization

    public bool player;
    public int health;
    public int Move1;  //for now pokemon will only have one move each.
    //public int Move2;
    //public int Move3;
    //public int Move4;
    void Start () {
        health = 1; //for now all pokemon will have 1 health, this will be changed later.
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void FixedUpdate()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<BasicBullet>();
    }


    public void useMove()
    {
        Move.Use(transform.position, true, Move1);
    }
}

public class Charizard : BasicPokemon
{
    Charizard()
    {
        Move1 = 1;

    }
}


