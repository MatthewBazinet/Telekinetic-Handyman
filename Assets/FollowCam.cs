using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
   public GameObject player;
   public int upOffset;
   public int sideOffset;
    public int backOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //transform.rotation = player.transform.rotation;
        transform.RotateAround(player.transform.position, Vector3.up, Input.GetAxis("Mouse X"));
        transform.position = player.transform.position + upOffset * player.transform.up + Quaternion.AngleAxis(-90, Vector3.up) * player.transform.forward * sideOffset - player.transform.forward * backOffset;
    }
}
