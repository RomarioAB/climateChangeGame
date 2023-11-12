using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerB : MonoBehaviour
{
    public GameObject Fire;
    public GameObject RainFall;
    public GameObject CorrectAnswer;
    public GameObject Smoke;
    public GameObject Ring;
    public GameObject AntarcticaTrigger;
    public GameObject MultipleChoice;
    public bool canEnter = false;

    void Update()
    {
        if (canEnter == true)
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                Destroy(Fire);
                Destroy(Smoke);
                Ring.SetActive(true);
                Destroy(MultipleChoice);
                RainFall.SetActive(true); //Activates rain fall
                AntarcticaTrigger.SetActive(true); //Activates travel trigger to Antarctica
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            canEnter = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        canEnter = false;
    }

}
