using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomLeaver : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

        }
    }
}
