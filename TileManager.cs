using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public static TileManager Instance { get; private set; }
    public BaseTile CurrentSelectedTile { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // public bool IsTileSelected => CurrentSelectedTile != null;
    public bool IsTileSelected
    {
        get 
        {
            bool isSelected = CurrentSelectedTile != null;
            Debug.Log("IsTileSelected: " + isSelected);
            return isSelected; 
        }
    }
  
    public void OnTileSelected(BaseTile selectedTile)
    {
        if (CurrentSelectedTile == selectedTile)
        {
            selectedTile.Deselect();
            CurrentSelectedTile = null;
            return;
        }
        else if (CurrentSelectedTile != null)
        {
            CurrentSelectedTile.Deselect();
            Debug.Log("TileManager: Previous tile deselected");
        }
        CurrentSelectedTile = selectedTile;
        CurrentSelectedTile.Select();
        Debug.Log("TileManager: Tile selected: " + CurrentSelectedTile.name);

    }

    public void HighlightStartingTiles()
    {
        StartTile[] startingTiles = FindObjectsOfType<StartTile>();
        foreach (StartTile tile in startingTiles)
        {
            tile.Highlight();
        }
    }
}


