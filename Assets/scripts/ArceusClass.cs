using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArceusClass : BasicPokemon
{
    // Use this for initialization
    void Start()
    {
        playerBool = false;
        health = 1; //for now all pokemon will have 1 health, this will be changed later.
        charge = 0;
        Move1 = 5;
        Move2 = 6;
        Move3 = 0;
        Move4 = 1;
    }
}