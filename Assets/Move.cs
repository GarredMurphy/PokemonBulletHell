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

    public static void Use(Vector3 position, bool player, int MoveID)
    {
        switch (MoveID)
            {

            case 0:  //test

                GameObject newBullet = Instantiate(genericBulletStatic);
                newBullet.transform.position = position;
                BasicBullet newBulletScript = newBullet.GetComponent<BasicBullet>();

                newBulletScript.velocity.y = 0.01f;
                break;
            case 1:  //flamethrower
                GameObject firestream[10];
                break;
        }
    }
}
