using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTile : BaseTile
{
    public override void Select()
    {
        base.Select();
    }

    public override void Deselect()
    {
        //base.Deselect();
        ChangeState(TileState.Highlighted, GameManager.Instance.gameSettings.starTileHighlightColor);
    }

    public override void Highlight()
    {
        //base.Highlight();
        ChangeState(TileState.Highlighted, GameManager.Instance.gameSettings.starTileHighlightColor);
    }

}