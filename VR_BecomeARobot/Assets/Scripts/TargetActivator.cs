using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetActivator : MonoBehaviour
{
    public bool Activated = true;
    public bool WantsToGrab = false;


    public void Update()
    {
        OVRInput.Update();

        

        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
            WantsToGrab = true;
        else
            WantsToGrab = false;
    }


    private void Activate()
    {
        if (Activated)
            Activated = false;
        else
            Activated = true;
    }
    
}
