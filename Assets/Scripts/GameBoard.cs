using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoard : MonoBehaviour
{
    public Sprite[] sprites;
    public Space spacePrefab;
    public int width, height;
    [System.NonSerialized] public Space[] spaces;

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

    public void createGameBoard() {
        spaces = new Space[width * height];
        for (int i = 0; i < width; i++) {
            for (int j = 0; j < height; j++) {
                var space = Instantiate(spacePrefab, transform.position + new Vector3(i, j, 0), Quaternion.identity);
                space.x = i;
                space.y = j;
                space.name = "Space (" + i + ", " + j + ")";
                spaces[j * width + i] = space;
            }
        }
    }

    public void deleteSpaces() {
        for (int i = 0; i < spaces.Length; i++) {
            Destroy(spaces[i]);
        }
    }


}
