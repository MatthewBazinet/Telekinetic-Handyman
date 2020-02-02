using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour


{
   private Vector3 mOffset;
   private float mZCoord;
    public Rigidbody rb;
    Vector3 newPos;
    public bool movable = true;
    private bool moving;

    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
        rb.useGravity = false;
        moving = true;
    }
    private void OnMouseUp()
    {
        rb.useGravity = true;
        moving = false;
    }
    private void FixedUpdate()
    {
        if (moving)
        {
            
            rb.MovePosition(newPos);
        }
    }

    void OnMouseDrag()
    {

        newPos = GetMouseWorldPos() + mOffset;

    }

    Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

}
