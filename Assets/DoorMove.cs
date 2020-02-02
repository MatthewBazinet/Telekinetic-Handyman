using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMove : MonoBehaviour
{
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        door.transform.position = door.transform.position + new Vector3(0, 0, 3.0f);

    }

    private void OnMouseUp()
    {

        door.transform.position = door.transform.position + new Vector3(0, 0, -3.0f);
    }

}
