using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube : MonoBehaviour
{
    public GameObject Cube;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            Destroy(Cube);
        }
    }
}
