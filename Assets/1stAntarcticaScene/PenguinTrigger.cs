using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinTrigger : MonoBehaviour
{
    public GameObject Penguin;
    public GameObject Arrow;

    void Start()
    {
        Penguin.SetActive(false);
        Arrow.SetActive(false);
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            Penguin.SetActive(true);
            Arrow.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(10);
        Destroy(Penguin);
        Destroy(gameObject);
    }
}