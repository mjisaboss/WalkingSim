using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{
    public AudioSource Music3;

    void OnTriggerEnter(Collider other)
    {
        Music3.Play();
    }
}
    




    
