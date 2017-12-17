﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGenerator : MonoBehaviour {//  I am using an L-system for this level generation code.


    public GameObject[] PokemonList;
    public static GameObject[] PokemonListStatic;

    public GameObject TheCanvas;

    public string lsystem;//a simple lsystem
    public string lsystemModified;
    public int recursions;
    public int index;

    public string vocabulary = "ABCD";

    public float timetonextwave;

    public static levelGenerator Instance { get; private set; }  //also using k

    private void Awake()
    {
        index = 0;
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }

        Instance = this;

        DontDestroyOnLoad(gameObject);

        PokemonListStatic = new GameObject[PokemonList.Length];

        for (int i = 0; i < PokemonList.Length; i++)
        {
            PokemonListStatic[i] = PokemonList[i];
        }

        lsystemModified = recursivestring(lsystem, recursions);

        recursions = Random.Range(0, 5);

        int seedLength  = Random.Range(3, 8);



        for (int i = 0; i < seedLength; i++)
        {
            int chosenletter = Random.Range(1, 5);
            switch (chosenletter)
            {
                case 1:
                    lsystem += "A";
                    break;
                case 2:
                    lsystem += "B";
                    break;
                case 3:
                    lsystem += "C";
                    break;
                case 4:
                    lsystem += "D";
                    break;

            }

        }



        //Canvas TheText = TheCanvas.Ge
        //TheText.

    }


    void Start () {
		
	}
	
	void FixedUpdate () {

        timetonextwave += Time.fixedDeltaTime;



        if (timetonextwave >= 6)
        {
            
            timetonextwave -= 6;
            if (index < lsystemModified.Length)
                callNextPokemon();
        }

		
	}



    private string recursivestring(string oldString, int recursionsremaining)
    {
        if (recursionsremaining > 0)
        {
            oldString.Replace("D", "DDD");
            oldString.Replace("C", "CCD");
            oldString.Replace("B", "CBC");
            oldString.Replace("A", "ABB");

            return recursivestring(oldString, recursionsremaining - 1);
        }

        return oldString;
    }

    private void callNextPokemon()
    {
        Vector3 startingposition = Vector3.zero;
        Vector3 targetposition = Vector3.zero;
        startingposition.y = 10;
        startingposition.x = Random.Range(-9f, 9f);
        targetposition.x = startingposition.x;
        targetposition.y = Random.Range(1f, 9f);

        for (int i = 0; i < vocabulary.Length; i++)
        {
            if (lsystemModified[index] == vocabulary[i])
            {
                GameObject newpokemon = Instantiate(PokemonListStatic[i]);
                BasicPokemon newpokemonscript = newpokemon.GetComponent<BasicPokemon>();
                newpokemon.transform.position = startingposition;
                newpokemonscript.targetLocation = targetposition;

            }
       
        }
        index++;


        


    }
}
