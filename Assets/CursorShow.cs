using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorShow : MonoBehaviour
{
    public Texture2D cursorTxtr;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(cursorTxtr, new Vector2(0, 0), CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
