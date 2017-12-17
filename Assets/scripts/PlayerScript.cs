using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class PlayerScript : MonoBehaviour {  //I am using a signleton for PlayerScript.  only one object of this class should ever exist.






    public static PlayerScript Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }

        Instance = this;

        DontDestroyOnLoad(gameObject);
    }
    public GameObject playerObject;

    Vector3 direction;


    private BasicPokemon playerPokemon;
	// Use this for initialization
	void Start () {
        playerPokemon = playerObject.GetComponent<BasicPokemon>();
        playerPokemon.playerBool = true;



	}
	
	// Update is called once per frame
	void FixedUpdate () {




        if (playerPokemon.charge >= 100)     //in future edits i probably will move the place where it checks the charge to someplace else;
        {
            if (Input.GetButton("Fire1"))
            {
                playerPokemon.useMove(1);
            }
            else if (Input.GetButton("Fire2"))
            {
                playerPokemon.charge = 0;
                playerPokemon.useMove(2);
            }
            else if (Input.GetButton("Fire3"))
            {
                playerPokemon.charge = 0;
                playerPokemon.useMove(3);
            }
            else if (Input.GetButton("Fire4"))
            {
                playerPokemon.charge = 0;
                playerPokemon.useMove(4);
            }
        }

        Vector3 mouseLocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseLocation.z = 0;

        direction.x = (mouseLocation.x - playerPokemon.transform.position.x);
        direction.y = (mouseLocation.y - playerPokemon.transform.position.y);

        if (direction.magnitude > .5f)
        {
            direction = Vector3.Normalize(direction);
        }
        playerPokemon.movement(direction);

        

    }
}
