using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StateMachine : MonoBehaviour
{
    public State startingState;
    private State currentState;
    
    private void Start()
    {
        currentState = startingState;
    }

    private void Update()
    {
        RunStateMachine();
    }
    private void RunStateMachine()
    {
        if (currentState == null)
        {
            return;
        }

        State nextState = currentState.Run(gameObject);

        if (nextState != null)
        {
            //Debug.logWarning(NextState);
            SwitchToNextState(nextState);
        }
    }
    private void SwitchToNextState(State next)
    {
        currentState = next;
    }

}
