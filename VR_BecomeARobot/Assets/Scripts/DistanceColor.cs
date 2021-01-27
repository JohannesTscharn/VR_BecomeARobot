using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteAlways]
public class DistanceColor : MonoBehaviour
{
    
    public GameObject VisionSphere0, VisionSphere1, VisionSphere2, VisionSphere3;
    public Vector3 VsPos0, VsPos1, VsPos2, VsPos3;
    


    void Start()
    {
        VisionSphere0 = GameObject.Find("VisionSphere0");
        VisionSphere1 = GameObject.Find("VisionSphere1");
        VisionSphere2 = GameObject.Find("VisionSphere2");
        VisionSphere3 = GameObject.Find("VisionSphere3");
    }
    
    void Update()
    {
        VsPos0 = VisionSphere0.transform.position;
        VsPos1 = VisionSphere1.transform.position;
        VsPos2 = VisionSphere2.transform.position;
        VsPos3 = VisionSphere3.transform.position;

        Shader.SetGlobalVector("_VsPos0", VsPos0);
        Shader.SetGlobalVector("_VsPos1", VsPos1);
        Shader.SetGlobalVector("_VsPos2", VsPos2);
        Shader.SetGlobalVector("_VsPos3", VsPos3);
    }
}
