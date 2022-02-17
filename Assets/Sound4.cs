using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound4 : MonoBehaviour
{
    public AudioSource Music4;

    void OnTriggerEnter(Collider other)
    {
        Music4.Play();
    }
}


