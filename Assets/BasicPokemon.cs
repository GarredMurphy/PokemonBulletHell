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
        if (charge < 300)
        { charge++; }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        BasicBullet hitobject = collision.gameObject.GetComponent<BasicBullet>();
        if (hitobject != null)
        {
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

public class Charizard : BasicPokemon
{
    private void Start()
    {

    }
   
};

public class Squirtle : BasicPokemon
{
    Squirtle()
    {
        Move1 = 0;
        Move1 = 0;
    }

};


