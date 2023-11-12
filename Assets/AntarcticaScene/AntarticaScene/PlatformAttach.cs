using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAttach : MonoBehaviour
{
    public GameObject Platform;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Player)
	{
	    Player.transform.parent = Platform.transform;
	}
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == Player)
	{
	    Player.transform.parent = null;
	}
    }
}


