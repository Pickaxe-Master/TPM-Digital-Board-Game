using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightStartingTilesState : IGameState
{
    public void OnStateEnter(GameManager gameManager)
    {
        // Logic for entering the HighlightStartingTiles state
        TileManager.Instance.HighlightStartingTiles();
    }

    public IGameState GetNextState(GameManager gameManager)
{
    // If you don't have a next state yet, just return null.
    return new SelectStartingTileState();
}

    public bool CanProgress(GameManager gameManager)
    {
        return TileManager.Instance.IsTileSelected;
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
        // Logic for exiting the HighlightStartingTiles state
    }
}
