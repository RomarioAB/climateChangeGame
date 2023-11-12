using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bin4 : MonoBehaviour
{
    public GameObject[] objects;
    public int objNum;
    public int objCount = 0;
    public bool canEnter = false;


    void Update()
    {
        if (canEnter == true)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {

                objNum = Random.Range(0, 1);
                objCount = 0;
                while (objCount < 1)
                {
                    objects[objCount].SetActive(false);
                    objCount += 1;
                }
                objects[objNum].SetActive(true);


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
