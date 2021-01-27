using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableObject : MonoBehaviour
{
    public GameObject ObjectiveController;
    public bool grabbed;
    public bool Bottle;
    public bool Fruit;

    public GameObject GrabSphere;
    private Rigidbody rigidbody;


    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (grabbed)
        {
            rigidbody.isKinematic = true;
            if (GrabSphere.GetComponent<ObjectGrabber>().WantsToGrab == false)
                grabbed = false;

            transform.position = GrabSphere.transform.position;
            transform.rotation = GrabSphere.transform.rotation;


            if (Bottle)
                ObjectiveController.GetComponent<ObjectiveController>().Bottlegrabbed = true;
            if (Fruit)
                ObjectiveController.GetComponent<ObjectiveController>().Fruitgrabbed = true;
        }
        else
        {
            rigidbody.isKinematic = false;

                if (Bottle)
                    ObjectiveController.GetComponent<ObjectiveController>().Bottlegrabbed = false;
                if (Fruit)
                    ObjectiveController.GetComponent<ObjectiveController>().Fruitgrabbed = false;
        }


    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("GrabSphere"))
        {
            if (other.GetComponent<ObjectGrabber>().WantsToGrab == true)
            {
                grabbed = true;
            }
        }
    }


}
