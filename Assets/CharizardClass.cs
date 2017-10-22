using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharizardClass : BasicPokemon {

	// Use this for initialization
	void Start () {
        player = false;
        health = 1; //for now all pokemon will have 1 health, this will be changed later.
        charge = 0;
        Move1 = 1;
        Move2 = 2;
    }
	

}
