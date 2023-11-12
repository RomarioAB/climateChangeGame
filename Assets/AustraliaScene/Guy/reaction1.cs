using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reaction1 : MonoBehaviour
{
    public GameObject guy;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            guy.GetComponent<Animator>().Play("disapproval");
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            guy.GetComponent<Animator>().Play("cheer");
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            guy.GetComponent<Animator>().Play("disapproval");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            guy.GetComponent<Animator>().Play("disapproval");
        }
    }
}
