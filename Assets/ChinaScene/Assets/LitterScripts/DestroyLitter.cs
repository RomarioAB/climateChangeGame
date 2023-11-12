using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLitter : MonoBehaviour
{
    public GameObject Litter;
   
    public bool canEnter = false;

    void Update()
    {
        if (canEnter == true)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                Destroy(Litter);
              
             
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
