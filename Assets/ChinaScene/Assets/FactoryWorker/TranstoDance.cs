using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranstoDance : MonoBehaviour
{
   public GameObject theNPC;

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            theNPC.GetComponent<Animator>().Play("Dancing");
        }
    }
}
