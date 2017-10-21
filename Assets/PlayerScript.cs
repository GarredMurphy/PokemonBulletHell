using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    public GameObject playerObject;
    
    private BasicPokemon playerPokemon;
	// Use this for initialization
	void Start () {
        playerPokemon = playerObject.GetComponent<BasicPokemon>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetButtonDown("Fire1"))
        {

            Move.Use(playerObject.transform.position, true, 0);
        }

    }
}
