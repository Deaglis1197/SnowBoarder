using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject FollowObject;

    // Update is called once per frame
    void Update()
    {
        transform.position=new Vector3(FollowObject.transform.position.x,FollowObject.transform.position.y,transform.position.z);
    }
}
