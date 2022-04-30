using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class BoardSetting{
    public int xSize, ySize;
    public Tile tileGO;
    public List<Sprite> tileSprite;
}

public class GameManager : MonoBehaviour
{
    [Header ("Game desk")]
    public BoardSetting boardSetting;

    private void Start() {
        BoardController.instance.SetValue(Board.instance.SetValue(boardSetting.xSize, boardSetting.ySize, boardSetting.tileGO, boardSetting.tileSprite),
            boardSetting.xSize, boardSetting.ySize,
            boardSetting.tileSprite);
    }
}