using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGameState
{
    void OnStateEnter(GameManager gameManager);
    IGameState GetNextState(GameManager gameManager);
    bool CanProgress(GameManager gameManager);
    bool WaitingInput(GameManager gameManager);
    void OnNextButtonPressed(GameManager gameManager);
    void OnStateExit(GameManager gameManager);
}
// public interface IGameState
// {
//     void OnEnter();
//     IGameState GetNextState();
//     bool CanProgress();
// }

