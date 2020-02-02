using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{

    public GameObject light;
    public GameObject door;
    public GameObject music;

    // Start is called before the first frame update
    void Start()
    {
        light.GetComponent<Light>().enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Battery")
        {
            door.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            light.GetComponent<Light>().enabled = true;
            other.attachedRigidbody.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
