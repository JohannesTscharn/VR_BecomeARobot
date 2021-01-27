using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceObjective : MonoBehaviour
{

    public GameObject ObjectiveController;
    public bool ObjectiveCompleted;


    public bool TableZone;
    public bool TableZoneIncorrect;
    public bool ShelfZone;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TaskObject"))
        {
            if (other.GetComponent<ObjectiveObject>().Bottle == true)
            {
                if (ShelfZone)
                    ObjectiveController.GetComponent<ObjectiveController>().ShelfCompleted = true;
            }

            if (other.GetComponent<ObjectiveObject>().Fruit == true)
            {
                if (TableZone)
                    ObjectiveController.GetComponent<ObjectiveController>().TableCompleted = true;
                if (TableZoneIncorrect)
                    ObjectiveController.GetComponent<ObjectiveController>().TableIncorrect = true;
            }
        }
    }

}
