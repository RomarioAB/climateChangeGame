using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogAudio : MonoBehaviour
{
    public GameObject AngryLogAudio;

    void OnTriggerEnter(Collider player)
    {
        AngryLogAudio.SetActive(true);
    }


    void OnTriggerExit(Collider player)

    {
        AngryLogAudio.SetActive(false);
    }
}
