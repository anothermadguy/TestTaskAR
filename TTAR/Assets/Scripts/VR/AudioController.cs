using System;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioController instance;
    
    public AudioSource grabSound;
    public AudioSource scoreSound;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void PlayGrabSound()
    {
        grabSound.Play();   
    }
    
    public void PlayScoreSound()
    {
        scoreSound.Play();   
    }
}
