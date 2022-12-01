using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public enum Type {Empty,Home,DoubleLetter,TripleLetter,QuadrupleLetter}
    public int x;
    public int y;
    public Type type;
    private Type prevType; // used to only update type when changed

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        prevType = (Type)((int)type + 1); // set differently from default so that sprite is initially set in Update
    }

    // Update is called once per frame
    void Update()
    {
        if (spriteRenderer == null) spriteRenderer = GetComponent<SpriteRenderer>();
        if (type != prevType) { // only update type when changed
            prevType = type;
            var board = GameObject.Find("GameBoard"); // gets the gameobject
            var boardAsGameBoard = board.GetComponent<GameBoard>(); // gets the gameobject in the correct format (GameBoard object)
            spriteRenderer.sprite = boardAsGameBoard.sprites[(int)type]; // updates this space's sprite
        }
    }

    public void setTypeNum(int typeNum) {
        type = (Type)typeNum;
        Update();
    }
}
