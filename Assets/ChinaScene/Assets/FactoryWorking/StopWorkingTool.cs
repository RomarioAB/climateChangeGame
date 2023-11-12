using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopWorkingTool : MonoBehaviour
{
    public GameObject woman;
    public bool canEnter = false;


    void Update()
    {
        if (canEnter == true)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                woman.GetComponent<Animator>().Play("Idle");
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

