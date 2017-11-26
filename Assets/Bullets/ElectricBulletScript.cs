using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricBulletScript : BasicBullet {

	// Use this for initialization
	void Start () {
        bulletype = typing.ELECTRIC;
	}

    protected override void specialbehavior()  //some bullets types behave differently than others.
    {
        gameObject.transform.position += (Quaternion.Euler(0, 0, Random.Range(0, 360)) * Vector3.up) / 15;
    }
}