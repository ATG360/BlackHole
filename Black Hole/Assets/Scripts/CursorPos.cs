using UnityEngine;
using System.Collections;

//	Abhi Tech Games (c)


public class CursorPos : MonoBehaviour
{
    
    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	transform.position = mousePos;
    }
}
