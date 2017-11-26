using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBulletScript : BasicBullet {

    // Use this for initialization
    void Start () {
        bulletype = typing.WATER;
    }

    protected override void specialbehavior()  //some bullets types behave differently than others.
    {
        
    }
}