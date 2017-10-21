using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentState : MonoBehaviour {  //This code will contain a finite state machine or two that determines what part of the menu you are in or if you are in the combat screen or the overworld.

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

class Startmenu : CurrentState
{
    
};

class Bverworld : CurrentState
{

};

class BattleScreen : CurrentState
{

};
