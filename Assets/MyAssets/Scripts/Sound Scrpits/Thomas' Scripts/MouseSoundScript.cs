using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSoundScript : MonoBehaviour
{
    public AudioSource MouseSound;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MouseSound.Play();
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MouseSound.Stop();
        }
    }
}
       