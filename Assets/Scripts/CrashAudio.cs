using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashAudio : MonoBehaviour
{
    public AudioSource audioSource; // Assign your AudioSource in the Inspector

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            audioSource.Play();
        }
    }
}
