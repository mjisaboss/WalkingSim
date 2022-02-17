using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music2 : MonoBehaviour
{
    public AudioSource Music4;

    void OnTriggerEnter(Collider other)
    {
        Music4.Play();
    }
}





