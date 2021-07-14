using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds2 : MonoBehaviour
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

        if (Input.GetKeyDown("d"))
        {
            playing = true;
            Audio.loop = true;
            Audio.Play();
        }
        if (Input.GetKeyDown("w"))
        {
            Audio.mute = true;
        }
        if (Input.GetKeyDown("a"))
        {
            Audio.mute = true;
        }
        if (Input.GetKeyDown("s"))
        {
            Audio.mute = true;
        }

        if (Input.GetKeyUp("d"))
        {
            playing = false;
            Audio.loop = false;
            Audio.Play();
        }
        
        if (Input.GetKeyUp("w"))
        {
            Audio.mute = false;
        }
        if (Input.GetKeyUp("s"))
        {
            Audio.mute = false;
        }
        if (Input.GetKeyUp("a"))
        {
            Audio.mute = false;
        }
    }
      
}
