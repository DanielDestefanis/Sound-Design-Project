using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds1 : MonoBehaviour
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
        Audio.pitch = Random.Range(0.5f, 2.5f);

        if (Input.GetKeyDown("s"))
         {
            playing = true;
            Audio.loop = true;
            Audio.Play();
         }
        if (Input.GetKeyDown("w"))
        {
            Audio.mute = true;
        }
        
        if (Input.GetKeyUp("s"))
        {
            playing = false;
            Audio.loop = false;
        }

        if (Input.GetKeyUp("w"))
        {
            Audio.mute = false;
        }
    }
}
