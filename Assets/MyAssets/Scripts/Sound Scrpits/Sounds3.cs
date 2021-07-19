using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds3 : MonoBehaviour
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

        if (Input.GetKeyDown("a"))
        {
            playing = true;
            Audio.loop = true;
            Audio.Play();
        }
        if (Input.GetKeyDown("w"))
        {
            Audio.mute = true;
        }
        if (Input.GetKeyDown("d"))
        {
            Audio.mute = true;
        }
        if (Input.GetKeyDown("s"))
        {
            Audio.mute = true;
        }

        if (Input.GetKeyUp("a"))
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
        if (Input.GetKeyUp("d"))
        {
            Audio.mute = false;
        }
    }
    
}
