using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPokemon : MonoBehaviour { // I am using type object for pokemon

    // Use this for initialization

    public bool playerBool;  
    public int health;
    public int Move1;
    public int Move2;
    public int Move3;
    public int Move4;

    public int charge;
    public int cooldown;  //not currently using.


    void Start () {
        health = 1; //for now all pokemon will have 1 health, this will be changed later.
        charge = 0;
        playerBool = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void FixedUpdate()
    {
        if (health <= 0)
        {
            if (!playerBool)
            {
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("GameOver");
            }
        }
        if (charge < 100)
        { charge++; }


        if (playerBool == false)
            if (charge >= 100)
            {
                useMove(1);
                charge = 0;
            }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("contact 0");
        //Debug.Log("hit something not a bullet");
        BasicBullet hitobject = collision.gameObject.GetComponent<BasicBullet>();
        if (hitobject != null)
        {
            //Debug.Log("contact A");
            //Debug.Log("hit something not a bullet");
            if (hitobject.player != playerBool)
            {
                //Debug.Log("contact B");
                health -= 1;
            }
        }
    }


    public void useMove(int moveChosen)
    {
        switch(moveChosen)
        {
            case 1:
                Move.Use(transform.position, playerBool, Move1);
                break;
            case 2:
                Move.Use(transform.position, playerBool, Move2);
                break;
            case 3:
                Move.Use(transform.position, playerBool, Move3);
                break;
            case 4:
                Move.Use(transform.position, playerBool, Move4);
                break;

        }
    }

    public void movement(Vector3 direction)
    {
        gameObject.transform.position += direction * .1f;

        Vector3 edgedetectorvector = gameObject.transform.position;

        if (edgedetectorvector.x >= 10)
        {
            edgedetectorvector.x = 10;
        }
        else if (edgedetectorvector.x <= -10)
        {
            edgedetectorvector.x = -10;
        }

        if (edgedetectorvector.y >= 10)
        {
            edgedetectorvector.y = 10;
        }
        else if (edgedetectorvector.y <= -10)
        {
            edgedetectorvector.y = -10;
        }

        gameObject.transform.position = edgedetectorvector;
    }

}