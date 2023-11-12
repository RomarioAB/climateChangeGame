using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AusIntro : MonoBehaviour
{
    public GameObject IntroAus;

    void Start()
    {
        IntroAus.SetActive(false);
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            IntroAus.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(10);
        Destroy(IntroAus);
        Destroy(gameObject);
    }

}