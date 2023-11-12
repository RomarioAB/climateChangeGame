using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audios : MonoBehaviour
{
    public AudioSource whale;
    public AudioSource Avalanche;

    void Start()
    {
        whale = gameObject.AddComponent<AudioSource>();
        Avalanche = gameObject.AddComponent<AudioSource>();

    }
}
