using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDelay : MonoBehaviour
{
    public GameObject Target;
    public float FollowSpeed = 0.05f;
    
    void Update()
    {
            transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, FollowSpeed);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Target.transform.rotation, 1.0f);
    }
}
