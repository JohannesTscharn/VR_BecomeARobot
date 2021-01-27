using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGrabber : MonoBehaviour
{
    public GameObject TargetSpehre;
    public bool WantsToGrab;
    public bool IsGrabbing;

    void Start()
    {
        
    }
    
    void Update()
    {
        WantsToGrab = TargetSpehre.GetComponent<TargetActivator>().WantsToGrab;
    }
}
