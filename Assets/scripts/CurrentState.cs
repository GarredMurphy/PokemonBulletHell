using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentState : MonoBehaviour //this is a finite state machine
{
    private int state;

    public int getstate()
    {
        return state;
    }

    private void Awake()
    {
        state = 1;
    }

    // state 1 is start menu;
    // state 2 is battle screen;
    // state 3 is 

    private bool changestate(int newstate)  //currently the finite state machine only has two possible states.  I wrote this such that i can easily add more states later.
    {
        switch (state)
        {
            case 1:
                if (newstate == 2)
                {
                    state = 2;
                    return true;
                }
                else return false;

                break;
            case 2:

                if (newstate == 1)
                {
                    state = 1;
                    return true;
                }
                else return false;
                
        }



        return false;
    } 



}