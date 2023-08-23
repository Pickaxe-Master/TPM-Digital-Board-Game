using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateMachine
{
    private IGameState currentState;

    public void ChangeState(IGameState newState)
    {
        if (currentState != null)
        {
            Debug.Log($"GameStateMachine: Changing state from {currentState.GetType().Name} to {newState.GetType().Name}");
        }
        else
        {
            Debug.Log($"GameStateMachine: Setting initial state to {newState.GetType().Name}");
        }

        currentState?.OnStateExit(GameManager.Instance);
        currentState = newState;
        currentState.OnStateEnter(GameManager.Instance);
    }

    public void ProgressState()
    {
        IGameState nextState = currentState.GetNextState(GameManager.Instance);
        if (nextState != null)
        {
            ChangeState(nextState);
            Debug.Log($"GameStateMachine: Progressing state from {currentState.GetType().Name} to {nextState.GetType().Name}");
        }
        else
        {
            Debug.Log($"GameStateMachine: No next state available after {currentState.GetType().Name}");
        }
    }

    public bool WaitingInput()
    {
        //return currentState.CanProgress(GameManager.Instance);
        bool waiting = currentState.CanProgress(GameManager.Instance);
        Debug.Log($"GameStateMachine: {currentState.GetType().Name} is {(waiting ? "" : "not ")}waiting for input.");
        return waiting;
    }

}


