using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBulletScript : BasicBullet {

    // Use this for initialization
    void Start () {
        bulletype = typing.FIRE;
    }

    protected override void specialbehavior()  //some bullets types behave differently than others.
    {

    }
}