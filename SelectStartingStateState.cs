using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectStartingTileState : IGameState
{
    public void OnStateEnter(GameManager gameManager)
    {
        // Logic for entering the NewState
    }

    public void OnStateExit(GameManager gameManager)
    {
        // Logic for exiting the NewState
    }

    public IGameState GetNextState(GameManager gameManager)
    {
        // Return the next state after NewState
        // Example: return new AnotherState();
        return new NewState();
    }

    public bool CanProgress(GameManager gameManager)
    {
        // Return true or false based on whether conditions are met to progress
        return false;
    }

    public bool WaitingInput(GameManager gameManager)
    {
        // Return true if waiting for user input, otherwise false
        return false;
    }

    public void OnNextButtonPressed(GameManager gameManager)
    {
        // Logic for handling the next button in the NewState
    }
}
