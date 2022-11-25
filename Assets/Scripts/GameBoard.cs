using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoard : MonoBehaviour
{
    public Sprite[] sprites;
    public Space spacePrefab;
    public int width, height;

    // Start is called before the first frame update
    void Start()
    {
        name = "GameBoard";
        createGameBoard();
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    void createGameBoard() {
        for (int i = 0; i < width; i++) {
            for (int j = 0; j < height; j++) {
                var space = Instantiate(spacePrefab, transform.position + new Vector3(i, j, 0), Quaternion.identity);
                space.x = i;
                space.y = j;
                space.name = "Space (" + i + ", " + j + ")";
            }
        }
    }

    // json is currently in the format "001111/111100/001111/111100/001111/111100/001111"
    void loadBoard(string json) {
        for (int i = 0; i < width; i++) {
            for (int j = 0; j < height; j++) {

            }
        }
    }
}
