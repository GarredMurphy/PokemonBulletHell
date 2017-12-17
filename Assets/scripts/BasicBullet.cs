using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBullet : MonoBehaviour {  // i will probably add more kinds of bullets to the use Type Object pattern with this as the base

    public bool playerbool;
    public Vector3 velocity;


    bool subbullet;  //these bools are for special bullet behavior i plan to add later
    bool damaged;
    bool parrentbullet;

    public enum typing  //This will be used to determine how bullets behave when they touch each other.
    {
        GENERIC,
        NORMAL,
        BUG,
        DARK,
        DRAGON,
        ELECTRIC,
        FAIRY,
        FIGHTING,
        FIRE,
        FLYING,
        GHOST,
        GRASS,
        GROUND,
        ICE,
        POISON,
        PSYCHIC,
        ROCK,
        STEEL,
        WATER
    }

    public typing bulletype;


    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    private void FixedUpdate()
    {
        gameObject.transform.position += velocity;

        if (gameObject.transform.position.y > 10 || gameObject.transform.position.y < -10 || gameObject.transform.position.x > 10 || gameObject.transform.position.y < -10)
        {
            Destroy(gameObject);
        }

        specialbehavior();  //some bullets types behave differently than others.
    }



    protected virtual void specialbehavior()  //some bullets types behave differently than others.
    {

    }

    private short typeEffectiveness(typing enemytype)  //when two bullets that are not both player bullets or both enemy bullets, this code will determine what happens
    {
        switch (bulletype)
        {
            case typing.NORMAL:
                break;
            case typing.BUG:
                break;
            case typing.DRAGON:
                if (enemytype == typing.FAIRY)  //if a fire bullet hits a water bullet then the water bullet is destroyed;
                {
                    return -1;
                }
                break;
            case typing.ELECTRIC:
                if (enemytype == typing.GROUND)
                {
                    return -1;
                }
                break;
            case typing.FAIRY:
                break;
            case typing.FIGHTING:
                break;
            case typing.FIRE:
                if (enemytype == typing.WATER)  //if a fire bullet hits a water bullet then the water bullet is destroyed;
                {
                    return -1;
                }
                break;
            case typing.FLYING:
                break;
            case typing.GHOST:
                break;
            case typing.GRASS:
                if (enemytype == typing.FIRE)
                {
                    return -1;
                }
                break;
            case typing.GROUND:
                
                break;
            case typing.ICE:
                if (enemytype == typing.FIRE)
                {
                    return -1;
                }
                break;
            case typing.POISON:
                break;
            case typing.PSYCHIC:
                break;
            case typing.ROCK:
                break;
            case typing.STEEL:
                break;
            case typing.WATER:
                break;

                
        }


            
        return 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        BasicBullet hitobject = collision.gameObject.GetComponent<BasicBullet>();
        if (hitobject != null)
        {
            if (hitobject.playerbool != playerbool)
            {
                if (typeEffectiveness(hitobject.bulletype) == -1)
                    Destroy(gameObject);


            }
        }

    }

}

