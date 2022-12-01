using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoardManager : MonoBehaviour
{
    public GameBoard boardPrefab;
    // Start is called before the first frame update
    void Start()
    {
        loadBoard("40304/02020/30103/02020/40304");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // json is currently in the format "001111/112300/001111/111100/001111/111100" where / delimits the rows
    // and each element represents a type of space for that element of the row.
    void loadBoard(string json) {
        string[] delimited = json.Split("/");
        // if json is empty/unparseable, don't load a board
        if (delimited.Length == 0 || (json.Length + 1 - delimited.Length) % delimited[0].Length != 0) return;
        var oldBoard = GameObject.Find("GameBoard"); // gets the gameobject
        if (oldBoard != null) {
            // gets the gameobject in the correct format (GameBoard object)
            var boardAsGameBoard = oldBoard.GetComponent<GameBoard>();
            if (boardAsGameBoard != null) {
                boardAsGameBoard.deleteSpaces(); Destroy(boardAsGameBoard); // deletes it if it exists
            }
        }
        var board = Instantiate(boardPrefab, boardPrefab.transform.position, Quaternion.identity).GetComponent<GameBoard>();
        board.name = "GameBoard";
        board.height = delimited.Length;
        board.width = delimited[0].Length;
        board.createGameBoard();
        for (int i = 0; i < board.width; i++) {
            for (int j = 0; j < board.height; j++) {
                // sets the type of the space triggering update
                board.spaces[j * board.width + i].setTypeNum(delimited[j][i] - '0'); 
            }
        }
    }
}
