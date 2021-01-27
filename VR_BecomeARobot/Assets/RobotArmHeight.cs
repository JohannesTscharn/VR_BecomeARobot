using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotArmHeight : MonoBehaviour
{
    public GameObject VRCamera;
    public float heightOffset = 0.5f;

    void Update()
    {
        transform.position = new Vector3(transform.position.x, VRCamera.transform.position.y - heightOffset, transform.position.z);
    }
}
