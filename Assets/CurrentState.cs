using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentState : MonoBehaviour {  //This code will contain a finite state machine or two that determines what part of the menu you are in or if you are in the combat screen or the overworld.
                             //Because of the problems I had with getting a finite state machine to work correctly during the midterm i am leaving this unfinished until i figure out what went wrong.
	
	void Start () {
		
	}     //later i am going to look up how to program a finite state machine in C#.  

    //StateSuperClass * currentStatePointer;

    //private static Startmenu startmenu;
    //private static Overworld overworld;
    //private static BattleScreen battleScreen;
    //private static Menu menu;


};

class StateSuperClass
{

}

class Startmenu : StateSuperClass //should be in this state when the game starts.
{
    
};

class Overworld : StateSuperClass  //Battlesceen is active
{

};

class BattleScreen : StateSuperClass  //You are moving around in the overworld
{

};

class Menu : StateSuperClass  //I don't know yet how many menu pages their will be.  Will add more as needed.
{ };

