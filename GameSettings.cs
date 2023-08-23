using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameSettings", menuName = "ScriptableObjects/GameSettings", order = 1)]
public class GameSettings : ScriptableObject
{
    public Color defaultColor = Color.blue;
    public Color selectedColor = Color.yellow;
    public Color highlightColor = Color.white;
    public Color starTileHighlightColor = Color.green;
    public Color usedColor = Color.gray;
    
    // ... (other configurable settings)
}