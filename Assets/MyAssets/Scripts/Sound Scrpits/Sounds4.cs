using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds4 : MonoBehaviour
{    
    public AudioSource[] soundFX;
    private bool playing = false;
    private bool Loop = false;
    AudioSource m_AudioSource;
    private AudioSource Audio;

    void Start()
    {
        Audio = GetComponent<AudioSource>();
        Audio.loop = false;
    }
    void Update()
    {

        if (Input.GetKeyDown("space"))
         {
             playing = true;
             Audio.loop = true;
             Audio.Play();
         }

        if (Input.GetKeyUp("space"))
        {
            playing = false;
            Audio.loop = false;
            Audio.Play();
        }
    }
    
}
