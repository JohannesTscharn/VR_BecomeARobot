using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveController : MonoBehaviour
{
    public GameObject TutorialController;
    public bool TutorialCompleted = true;

    public GameObject Bottle;
    public bool Bottlegrabbed;
    public GameObject Fruit;
    public bool Fruitgrabbed;

    public GameObject ObjectGrabber;

    public GameObject TableZone;
    public GameObject TableZoneIncorrect;
    public GameObject ShelfZone;


    public GameObject ShelfTask1;
    public GameObject ShelfTask2;
    public GameObject TableTask1;
    public GameObject TableTask2;

    public GameObject ShelfZoneReached;
    public GameObject TableZoneReached;
    public GameObject TableZoneIncorrectReached;

    public GameObject LeaveRoom;

    public bool CurrentTaskTable;
    public bool CurrentTaskShelf;

    public bool ShelfTaskPart1;
    public bool ShelfTaskPart2;
    public bool ShelfCompleted;
    public bool TableTaskPart1;
    public bool TableCompleted;
    public bool TableIncorrect;
    public bool ObjectivesCompleted;

    void Update()
    {

        // START TASKS
        if (!TutorialCompleted)
        {
            // TutorialCompleted = TutorialController.GetComponent<TutorialController>().TutorialFinished;
        }
        

            if (CurrentTaskShelf)
            {
                if (ShelfTaskPart1)
                    StartCoroutine(ShelfTask1Delay());
                if (ShelfTaskPart2)
                    StartCoroutine(ShelfTask2Delay());


                if (ShelfCompleted)
                {
                    StartCoroutine(ShelfTaskDoneDelay());
                }
            }


            if (CurrentTaskTable)
            {
                if (TableTaskPart1)
                    StartCoroutine(TableTaskDelay());

                if (TableIncorrect)
                {
                        StartCoroutine(TableIncorrectDelay());
                }

                if (TableCompleted)
                {
                        StartCoroutine(TableTaskDoneDelay());
                }
            }

            if (ObjectivesCompleted)
            {
                StartCoroutine(LeaveRoomDelay());
            }



            /*
            if (CurrentTaskShelf)
            {
                if (ShelfTask1 != null)
                    StartCoroutine(ShelfTask1Delay());

                if (Bottlegrabbed)
                {
                    if (ShelfTask2 != null)
                        StartCoroutine(ShelfTask2Delay());
                }

                if (ShelfCompleted)
                {
                    if (ShelfZoneReached != null)
                        StartCoroutine(ShelfTaskDoneDelay());
                }
            }

            if (CurrentTaskTable)
            {
                if (TableTask1 != null)
                    StartCoroutine(TableTaskDelay());



                if (TableIncorrect)
                {
                    if (TableZoneReached != null)
                        StartCoroutine(TableTaskDoneDelay());
                }

                if (TableCompleted)
                {
                    if (TableZoneReached != null)
                        StartCoroutine(TableTaskDoneDelay());
                }
            }

        }

        if (TableCompleted && ShelfCompleted)
        {
            StartCoroutine(LeaveRoomDelay());
            LeaveRoomCollider.SetActive(true);
        }
        */

        

    }
    

    IEnumerator ShelfTask1Delay()
    {
        yield return new WaitForSeconds(1);
        ShelfTask1.SetActive(true);
        yield return new WaitForSeconds(12);
            ShelfTask1.SetActive(false);
        }
    IEnumerator ShelfTask2Delay()
    {
        yield return new WaitForSeconds(2);
        ShelfTask2.SetActive(true);
        yield return new WaitForSeconds(12);
        ShelfTask2.SetActive(false);
        }
    IEnumerator ShelfTaskDoneDelay()
    {
        yield return new WaitForSeconds(1);
        ShelfZoneReached.SetActive(true);
        yield return new WaitForSeconds(4);
        ShelfZoneReached.SetActive(false);
        }
    IEnumerator TableTaskDelay()
    {
        yield return new WaitForSeconds(1);
        TableTask1.SetActive(true);
        yield return new WaitForSeconds(14);
        TableTask1.SetActive(false);
    }

    IEnumerator TableIncorrectDelay()
    {
        yield return new WaitForSeconds(1);
        TableZoneIncorrectReached.SetActive(true);
        yield return new WaitForSeconds(10);
        TableZoneIncorrectReached.SetActive(false);
    }
    IEnumerator TableTaskDoneDelay()
    {
        yield return new WaitForSeconds(1);
        TableZoneReached.SetActive(true);
        yield return new WaitForSeconds(4);
        TableZoneReached.SetActive(false);
    }

    IEnumerator LeaveRoomDelay()
    {
        yield return new WaitForSeconds(1);
        LeaveRoom.SetActive(true);
        yield return new WaitForSeconds(10);
        LeaveRoom.SetActive(false);
    }

}
