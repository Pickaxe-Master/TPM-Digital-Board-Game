using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileL0 : BaseTile
{
    // Call this method to select this tile
    public override void Select()
    {
        base.Select();
        // Specific code for TileL1 when selected
    }

    // Call this method to deselect this tile
    public override void Deselect()
    {
        base.Deselect();
        // Specific code for TileL1 when deselected
    }
}