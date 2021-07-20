using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderSoundScript : MonoBehaviour
{
    public AudioSource SpiderSound;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SpiderSound.Play();
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SpiderSound.Stop();
        }
        
    }
}