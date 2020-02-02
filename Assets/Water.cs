using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
   public ParticleSystem ps;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
         if(other.gameObject.tag == "Pipe")
          {
        ps.Stop();
            door.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            other.attachedRigidbody.freezeRotation =true;
            other.attachedRigidbody.useGravity = false;
            other.attachedRigidbody.constraints = RigidbodyConstraints.FreezeAll;

        }
    }
}
