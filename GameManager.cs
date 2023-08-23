using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public GameSettings gameSettings;
    private GameStateMachine gameStateMachine;
    //private IGameState currentState;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            gameStateMachine = new GameStateMachine();  // Initialize the gameStateMachine
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        Debug.Log("GameManager: Start");
        // prep and reset
            // clean previous game   
        // starting new game
        gameStateMachine.ChangeState(new WaitingForStartState());
    }

    public bool CanProgress()
    {
        return gameStateMachine.WaitingInput();
    }


    public void OnNextButtonPressed()
    {
        if (CanProgress())
        {
            Debug.Log("Progressing to the next game state");
            gameStateMachine.ProgressState();
        }
        else
        {
            // Provide feedback to the player, e.g., display a message that they need to select a tile first
            Debug.LogWarning("conditions to progress from state. Example: select a tile before proceeding.");
        }
    }
}

// To Do:
// Starting Tiles (tiles manager)
// text on screen to inform
// open start tile selection
// whait for all players

// flip deck tiles (deck mamanger)
// pass the turn (game manager)

// select tile (tile manager)
// select tile from the deck(deck manager)
// rotate tile (tile & tile manager)
// accept placment (tile manager)

// calculate stats (tile manager)
// pass the turn (game manager)

// Debug.Log("GameManager:  Waiting for players input");

// try
// {
//     // some code that might throw an exception
// }
// catch (Exception e)
// {
//     Debug.LogError($"An error occurred: {e.Message}");
// }