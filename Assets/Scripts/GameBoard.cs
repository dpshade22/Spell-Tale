using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoard : MonoBehaviour
{
    public Space spacePrefab;
    public int width, height;

    // Start is called before the first frame update
    void Start()
    {
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
}
