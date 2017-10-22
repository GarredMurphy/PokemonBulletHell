using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour { // i may later change this to use a different design pattern if it works better.

    public GameObject genericBullet;
    public static GameObject genericBulletStatic;

    public void Awake()
    {
        genericBulletStatic = genericBullet;
    }

    public static void Use(Vector3 position, bool player, int MoveID)  //I plan to heavily rewrite how moves work in the game. in future versions, use will take more parameters
    {
        GameObject bulletsCreated;
        BasicBullet newBulletScript;

        short reverse = 1;
        if (player != true)
        {
            reverse = -1;
        }

        switch (MoveID)
        {

            case 0:  // water gun

                for (int i = 0; i < 10; i++)
                {
                    bulletsCreated = Instantiate(genericBulletStatic);
                    bulletsCreated.transform.position = position;
                    newBulletScript = bulletsCreated.GetComponent<BasicBullet>();
                    newBulletScript.player = player;

                    newBulletScript.velocity.y = 0.01f * (i + 1) * reverse;

                }
                break;

            case 1: // flame thrower
                for (int i = 0; i < 10; i++)
                {
                    bulletsCreated = Instantiate(genericBulletStatic);
                    bulletsCreated.transform.position = position;
                    newBulletScript = bulletsCreated.GetComponent<BasicBullet>();
                    newBulletScript.player = player;

                    newBulletScript.velocity.y = 0.01f * (i + 1) * reverse;
                    newBulletScript.velocity.x = Random.Range(0.005f, -0.005f);

                }
                break;
            case 2: // fireblast
                for (int i = 0; i < 10; i++)
                {


                    bulletsCreated = Instantiate(genericBulletStatic);
                    bulletsCreated.transform.position = position;
                    newBulletScript = bulletsCreated.GetComponent<BasicBullet>();
                    newBulletScript.player = player;

                    newBulletScript.velocity.y = 0.07f;

                    newBulletScript.velocity.x = 0.01f * (2 - (i % 5));

                    if (i < 5)
                    {
                        newBulletScript.velocity.y *= .5f;
                        newBulletScript.velocity.x *= .5f;
                    }
                   
                    newBulletScript.velocity.y *= reverse;

                    
                }

                break;
        }
    }
}
