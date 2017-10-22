using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPokemon : MonoBehaviour { // I am using type object for pokemon

    // Use this for initialization

    public bool player;  
    public int health;
    public int Move1;  //for now pokemon will only have two moves each.
    public int Move2;

    public int charge;

    //public int Move3;
    //public int Move4;
    void Start () {
        health = 1; //for now all pokemon will have 1 health, this will be changed later.
        charge = 0;
        player = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void FixedUpdate()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        if (charge < 100)
        { charge++; }


        if (player == false)
            if (charge >= 100)
            {
                useMove(1);
                charge = 0;
            }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hit something not a bullet");
        BasicBullet hitobject = collision.gameObject.GetComponent<BasicBullet>();
        if (hitobject != null)
        {
            Debug.Log("hit something not a bullet");
            if (hitobject.player != player)
            health -= 1;
        }
    }


    public void useMove(int moveChosen)
    {
        switch(moveChosen)
        {
            case 1:
                Move.Use(transform.position, player, Move1);
                break;
            case 2:
                Move.Use(transform.position, player, Move2);
                break;
            
        }
    }
}