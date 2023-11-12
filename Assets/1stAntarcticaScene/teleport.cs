using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform Target;
    public GameObject FPS;

    void Update()
    {
       if(Input.GetKeyDown(KeyCode.T))
        {
            FPS.transform.position = Target.transform.position;
        }

    }
}
