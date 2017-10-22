using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    public GameObject playerObject;
    
    private BasicPokemon playerPokemon;
	// Use this for initialization
	void Start () {
        playerPokemon = playerObject.GetComponent<BasicPokemon>();
        playerPokemon.player = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (playerPokemon.charge >= 300)     //in future edits i probably will move the place where it checks the charge to someplace else;
        {
            if (Input.GetButton("Fire1"))
            {
                playerPokemon.charge = 0;
                playerPokemon.useMove(1);
            }
            else if (Input.GetButton("Fire2"))
            {
                playerPokemon.charge = 0;
                playerPokemon.useMove(2);
            }
            /*else if (Input.GetButton("Fire3"))
            {
                playerPokemon.charge = 0;
                playerPokemon.useMove(4);
            }
            else if (Input.GetButton("Fire1"))
            {
                playerPokemon.charge = 0;
                playerPokemon.useMove(1);
            } */
            


        }
    }
}
