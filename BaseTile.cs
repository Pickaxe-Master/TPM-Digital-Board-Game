using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTile : MonoBehaviour
{
    protected enum TileState { Highlighted, Idle, Selected, Inactive }
    protected TileState currentState = TileState.Inactive;
    protected SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Click touch behaviour
    // Click Mouse behaviour
    private void OnMouseUp()
    {
        //TileClicked?.Invoke(this);
        if (currentState != TileState.Inactive)
        {
            //TileClicked?.Invoke(this);
            Debug.Log($"BaseTile: Mouse clicked on {gameObject.name}");
            TileManager.Instance.OnTileSelected(this);
        }
        else
        {
            Debug.Log($"BaseTile: Tile {gameObject.name} is inactive and cannot be selected.");
        }
    }

    public virtual void Select()
    {
        ChangeState(TileState.Selected, GameManager.Instance.gameSettings.selectedColor);
    }

    public virtual void Deselect()
    {
        ChangeState(TileState.Idle, GameManager.Instance.gameSettings.defaultColor);
    }

    public virtual void Highlight()
    {
        ChangeState(TileState.Highlighted, GameManager.Instance.gameSettings.highlightColor);
    }

    protected void ChangeState(TileState newState, Color newColor)
    {
        if (currentState != newState)
        {
            Debug.Log($"BaseTile: Tile {gameObject.name} changed state from {currentState} to {newState}");
            currentState = newState;
            spriteRenderer.color = newColor;
        }
        else
        {
            Debug.Log($"BaseTile: Tile {gameObject.name} is already in {newState} state");
        }
    }
}
