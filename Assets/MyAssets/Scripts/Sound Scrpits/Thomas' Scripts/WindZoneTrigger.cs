using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindZoneTrigger : MonoBehaviour
{
    public AudioSource WindSound;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            WindSound.Play();
        }
        
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            WindSound.Stop();
        }
    }

}
