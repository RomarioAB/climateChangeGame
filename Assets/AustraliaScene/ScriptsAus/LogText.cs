using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogText : MonoBehaviour
{
    public GameObject AngryLogSpeech;
    public GameObject Arrow;

    void Start()
    {
        AngryLogSpeech.SetActive(false);
        Arrow.SetActive(false);

    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            AngryLogSpeech.SetActive(true);
            Arrow.SetActive(true);

            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(10);
        Destroy(AngryLogSpeech);
        Destroy(gameObject);
    }

}