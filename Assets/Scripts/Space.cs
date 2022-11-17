using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space : MonoBehaviour
{
    public enum Type {Empty,}
    public int x;
    public int y;
    public Type type;

    // Start is called before the first frame update
    void Start()
    {
        type = Type.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
