using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController : MonoBehaviour
{
    public bool TutorialStarted;
    public bool TutorialFinished;

    public bool p0;
    public bool p1;
    public bool p2;
    public bool p3;
    public bool p4;
    public bool p5;
    public bool p6;
    public bool p7;

    public GameObject TutorialStartText;
    public GameObject VisionConstraint;

    public GameObject ObjectivesA;
    public GameObject ObjectivesAPS;
    public GameObject ObjectivesB;
    public GameObject ObjectivesBPS;
    public GameObject RobotArm;
    public GameObject TutorialGrabObject;
    public GameObject TutorialGrabObjectPS;
    public GameObject TutorialEnvironment;
    public GameObject Environment;
    public GameObject Environment_Start;

    public GameObject TutIntro;
    public GameObject Tut1FOV;
    public GameObject Tut2Move;
    public GameObject Tut3Arm;
    public GameObject Tut4Arm;
    public GameObject Tut5Grab;
    public GameObject Tut6Outro;


    private void Start()
    {

        Environment_Start.SetActive(false);
        Environment.SetActive(false);
    }

    void Update()
    {
        OVRInput.Update();

        // Tutorial Start
        // ----------------------------------------------------------
        if (TutorialStarted)
        {
            Destroy(TutorialStartText);
            VisionConstraint.SetActive(true);
        }
        else
            TutorialStartText.SetActive(true);

        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
        {
            if (!TutorialStarted)
            {
                TutorialStarted = true;
                p0 = true;
            }
        }
        // ----------------------------------------------------------

        // Tutorial Ongoing
        // ----------------------------------------------------------
        if (TutorialStarted && !TutorialFinished)
        {
            if (p0)
            {
                Environment_Start.SetActive(true);
                TutIntro.SetActive(true);
                //StartCoroutine(P1Delay(5.0f));
            }
            // Vision Phase 1
            if (p1)
            {
                p0 = false;
                TutIntro.SetActive(false);
                Tut1FOV.SetActive(true);
                Environment_Start.SetActive(false);
                Environment.SetActive(true);
                VisionConstraint.SetActive(true);
                //StartCoroutine(P2Delay(10.0f));
            }
            
            // Movement Phase 2
            if (p2)
            {
                p1 = false;
                Tut1FOV.SetActive(false);
                Tut2Move.SetActive(true);
                //StartCoroutine(P3Delay(10.0f));
            }
            
            // Arm Phase 3
            if (p3)
            {
                p2 = false;
                Tut2Move.SetActive(false);
                Tut3Arm.SetActive(true);
                RobotArm.SetActive(true);
                //StartCoroutine(P4Delay(10.0f));
            }

            if (p4)
            {
                p3 = false;
                Tut3Arm.SetActive(false);
                Tut4Arm.SetActive(true);
                //StartCoroutine(P5Delay(9.0f));
            }

            if (p5)
            {
                p4 = false;
                Tut4Arm.SetActive(false);
                Tut5Grab.SetActive(true);
                TutorialGrabObject.SetActive(true);
                TutorialGrabObjectPS.SetActive(true);
                //StartCoroutine(P6Delay(10.0f));
            }

            if (p6)
            {
                p5 = false;
                Tut5Grab.SetActive(false);
                Tut6Outro.SetActive(true);
                //StartCoroutine(P7Delay(10.0f));
            }
            if (p7)
            {
                p6 = false;
                //TutorialEnvironment.SetActive(false);
                Environment.SetActive(true);

                TutorialGrabObject.SetActive(false);
                TutorialGrabObjectPS.SetActive(false);

                Tut6Outro.SetActive(false);

                ObjectivesA.SetActive(true);
                ObjectivesAPS.SetActive(true);
                ObjectivesB.SetActive(true);
                ObjectivesBPS.SetActive(true);

                TutorialFinished = true;
            }
                
        }
        // ----------------------------------------------------------
    }
    

    IEnumerator P1Delay(float delay)
    {
        yield return new WaitForSeconds(delay);
        p1 = true;
        p0 = false;
    }

    IEnumerator P2Delay(float delay)
    {
        yield return new WaitForSeconds(delay);
        p2 = true;
        p1 = false;
    }
    IEnumerator P3Delay(float delay)
    {
        yield return new WaitForSeconds(delay);
        p3 = true;
        p2 = false;
    }
    IEnumerator P4Delay(float delay)
    {
        yield return new WaitForSeconds(delay);
        p4 = true;
        p3 = false;
    }
    IEnumerator P5Delay(float delay)
    {
        yield return new WaitForSeconds(delay);
        p5 = true;
        p4 = false;
    }
    IEnumerator P6Delay(float delay)
    {
        yield return new WaitForSeconds(delay);
        p6 = true;
        p5 = false;
    }
    IEnumerator P7Delay(float delay)
    {
        yield return new WaitForSeconds(delay);
        p7 = true;
        p6 = false;
    }








}
