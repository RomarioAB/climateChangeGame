using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToxicWasteInfo : MonoBehaviour
{
    public GameObject TWinfo;

    void Start()
    {
        TWinfo.SetActive(false);
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            TWinfo.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(12);
        Destroy(TWinfo);
        Destroy(gameObject);
    }

}