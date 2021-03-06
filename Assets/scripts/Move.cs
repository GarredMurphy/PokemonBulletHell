﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour { // This is now using singleton. only one object of this class should ever exist.


    public static Move Instance { get; private set; }








    public GameObject[] NPCBulletList;

    public static GameObject[] NPCBulletListStatic = new GameObject[19];

    public GameObject[] PlayerBulletList;

    public static GameObject[] PlayerBulletListStatic = new GameObject[19];



    /*
    public struct BulletList
    {
        GameObject generic;     // 0
        GameObject normal;      // 1
        GameObject bug;         // 2
        GameObject dark;        // 3
        GameObject dragon;      // 4
        GameObject electric;    // 5
        GameObject fairy;       // 6
        GameObject fighting;    // 7
        GameObject fire;        // 8
        GameObject flying;      // 9
        GameObject ghost;       //10
        GameObject grass;       //11
        GameObject ground;      //12
        GameObject ice;         //13
        GameObject poison;      //14
        GameObject psychic;     //15
        GameObject rock;        //16
        GameObject steel;       //17
        GameObject water;       //18
    }
    public BulletList PlayerBulletList;
    */


    public void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }

        Instance = this;

        DontDestroyOnLoad(gameObject);



        for (int i = 0; i <= 18; i++)
        {
            NPCBulletListStatic[i] = NPCBulletList[i];
            PlayerBulletListStatic[i] = PlayerBulletList[i];
        }
    }

    

    public static void Use(Vector3 position, bool player, int MoveID, ref int charge)  //Still am not finished working on this.
    {
        

        short reverse = 1;
        if (player != true)
        {
            reverse = -1;

            UseSwitch(position, player, MoveID, reverse, NPCBulletListStatic, ref charge);
        }
        else
        {
            UseSwitch(position, player, MoveID, reverse, PlayerBulletListStatic, ref charge);
        }


        


    }
    public static void UseSwitch(Vector3 position, bool player, int MoveID, short reverse, GameObject[] bulletList, ref int charge)
    {
        GameObject bulletsCreated;
        BasicBullet newBulletScript;


        charge = 0; //i later will move this into the moves so that some moves will affect the charge differently.

        switch (MoveID)
        {


            case 0:  // water gun

                for (int i = 0; i < 10; i++)
                {
                    bulletsCreated = Instantiate(bulletList[18]);  //              in future edits of this,   
                    bulletsCreated.transform.position = position;  //              i will make this part of the code
                    newBulletScript = bulletsCreated.GetComponent<BasicBullet>();//a seperate method so
                    newBulletScript.playerbool = player;//                             i won't have to copy so much for each move

                    newBulletScript.velocity.y = 0.01f * (i + 1) * reverse;

                }
                break;

            case 1: // flame thrower
                for (int i = 0; i < 10; i++)
                {
                    bulletsCreated = Instantiate(bulletList[8]);
                    bulletsCreated.transform.position = position;
                    newBulletScript = bulletsCreated.GetComponent<BasicBullet>();
                    newBulletScript.playerbool = player;

                    newBulletScript.velocity.y = 0.01f * (i + 1) * reverse;
                    newBulletScript.velocity.x = Random.Range(0.005f, -0.005f);

                }
                break;
            case 2: // fireblast
                for (int i = 0; i < 10; i++)
                {


                    bulletsCreated = Instantiate(bulletList[8]);
                    bulletsCreated.transform.position = position;
                    newBulletScript = bulletsCreated.GetComponent<BasicBullet>();
                    newBulletScript.playerbool = player;

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
            case 3: //earthquake

                for (int i = 0; i < 20; i++)
                {
                    bulletsCreated = Instantiate(bulletList[12]);
                    bulletsCreated.transform.position = position;
                    newBulletScript = bulletsCreated.GetComponent<BasicBullet>();
                    newBulletScript.playerbool = player;

                    newBulletScript.velocity = Vector3.up / 5;


                    newBulletScript.velocity = Quaternion.Euler(0, 0, i * 18) * newBulletScript.velocity;

                    
                }
                break;
            case 4: //overheat
                //Debug.Log("used overheat");
                for (int i = 0; i < 30; i++)
                {
                    bulletsCreated = Instantiate(bulletList[8]);
                    bulletsCreated.transform.position = position;
                    newBulletScript = bulletsCreated.GetComponent<BasicBullet>();
                    newBulletScript.playerbool = player;

                    newBulletScript.velocity = Vector3.up / Random.Range(50f, 100f);


                    newBulletScript.velocity = Quaternion.Euler(0, 0, i * 12) * newBulletScript.velocity;


                }
                break;

            case 5: //Judgement

                for (int i = 0; i < 20; i++)
                {

                    bulletsCreated = Instantiate(bulletList[ Random.Range(1, 19) ] );

                    bulletsCreated.transform.position = position;
                    newBulletScript = bulletsCreated.GetComponent<BasicBullet>();
                    newBulletScript.playerbool = player;

                    newBulletScript.velocity.y = Random.Range(0f, .1f);


                    newBulletScript.velocity = Quaternion.Euler(0, 0, Random.Range(0,360)) * newBulletScript.velocity;
                    newBulletScript.velocity.y += reverse * .07f;

                }
                break;
            case 6:  // thundershock

                for (int i = 0; i < 10; i++)
                {
                    bulletsCreated = Instantiate(bulletList[5]);  //              in future edits of this,   
                    bulletsCreated.transform.position = position;  //              i will make this part of the code
                    newBulletScript = bulletsCreated.GetComponent<BasicBullet>();//a seperate method so
                    newBulletScript.playerbool = player;//                             i won't have to copy so much for each move

                    newBulletScript.velocity.y = 0.01f * (i + 1) * reverse;

                }
                break;
            case 7:  // splash

                
                Vector3 direction = Quaternion.Euler(0, 0, Random.Range(0, 360)) * Vector3.down;

                for (int i = 0; i < 4; i++)
                {
                    bulletsCreated = Instantiate(bulletList[1]);           
                    bulletsCreated.transform.position = position;  
                    newBulletScript = bulletsCreated.GetComponent<BasicBullet>();
                    newBulletScript.playerbool = player;

                   

                    newBulletScript.velocity = Quaternion.Euler(0, 0, i * 90) * direction / 50;
                }
                break;
            case 8: // vine whip
                for (int i = 0; i < 5; i++)
                {
                    bulletsCreated = Instantiate(bulletList[11]);   
                    bulletsCreated.transform.position = position;
                    newBulletScript = bulletsCreated.GetComponent<BasicBullet>();
                    newBulletScript.playerbool = player;

                    newBulletScript.velocity.y = 0.01f * (i + 5) * reverse;

                    newBulletScript.velocity = Quaternion.Euler(0, 0, (i * 2) - 4) * newBulletScript.velocity;
                }
                break;
        }
    }
}
