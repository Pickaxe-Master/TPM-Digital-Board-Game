using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitingForStartState : IGameState
{
    public void OnStateEnter(GameManager gameManager)
    {
        // Logic for entering the WaitingForStart state
    }

    public IGameState GetNextState(GameManager gameManager)
    {
        return new HighlightStartingTilesState();
    }

    public bool CanProgress(GameManager gameManager)
    {
        // Implement logic to determine if you can progress from this state
        // For example, check if a certain condition in the gameManager is met
        return true; // Temporary placeholder
    }

    public bool WaitingInput(GameManager gameManager)
    {
        return true;  // This should return whether the game is waiting for input or not
    }

    public void OnNextButtonPressed(GameManager gameManager)
    {
        if (CanProgress(gameManager))
        {
            gameManager.OnNextButtonPressed();  // Progress to the next state
        }
        // Logic for handling the next button in the WaitingForStart state
        //gameManager.TransitionToState(new HighlightStartingTilesState());
        //gameManager.gameStateMachine.ChangeState(new HighlightStartingTilesState());
    }

    public void OnStateExit(GameManager gameManager)
    {
        // Logic for exiting the WaitingForStart state
    }
}
    /*
    private GameStateMachine gameStateMachine;

    public WaitingForStartState(GameStateMachine gameStateMachine)
    {
        this.gameStateMachine = gameStateMachine;
    }

    public void OnEnter()
    {
        // Logic for when this state is entered
        Debug.Log("Entered WaitingForStartState");
    }

    public IGameState GetNextState()
    {
        return new HighlightStartingTilesState(gameStateMachine);
    }

    public bool CanProgress()
    {
        // Logic to determine if we can progress from this state
        return true;  // For example
    }  */


