using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
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
        
        Audio.pitch = Random.Range(0.5f, 1.7f);

        if (Input.GetKeyDown("w"))
        {
            playing = true;
            Audio.loop = true;
            Audio.Play();
        }
        if (Input.GetKeyDown("s"))
        {
            Audio.mute = true;
        }

        if (Input.GetKeyUp("w"))
        {
            playing = false;
            Audio.loop = false;
            Audio.Play();
        }
        if (Input.GetKeyUp("s"))
        {
            Audio.mute = false;
        }
    }
    
}
