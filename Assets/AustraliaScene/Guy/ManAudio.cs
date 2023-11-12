using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManAudio : MonoBehaviour
{
    public AudioSource Grunt;
    public AudioSource Happy;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Grunt.Play();
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Happy.Play();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Grunt.Play();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Grunt.Play();
        }
    }
}

