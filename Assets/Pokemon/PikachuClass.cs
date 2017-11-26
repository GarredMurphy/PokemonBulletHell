using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PikachuClass : BasicPokemon {

    // Use this for initialization
    void Start()
    {
        playerBool = false;
        health = 1; //for now all pokemon will have 1 health, this will be changed later.
        charge = 0;
        Move1 = 6;
        Move2 = 6;
        Move3 = 7;
        Move4 = 8;
    }
}
