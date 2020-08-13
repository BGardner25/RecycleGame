using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    //public static AudioManager audioManager;
    public AudioMixerGroup audioMixer;
    public Sound[] soundArr;

    void Awake()
    { 
        /*if (audioManager != null)
        {
            Destroy(gameObject);
            return;
        }
        else
            audioManager = this;

        DontDestroyOnLoad(gameObject);*/
        foreach (Sound sound in soundArr)
        {
            sound.aSrc = gameObject.AddComponent<AudioSource>();
            sound.aSrc.outputAudioMixerGroup = audioMixer;
            sound.aSrc.clip = sound.audioClip;
            sound.aSrc.volume = sound.volume;
            sound.aSrc.pitch = sound.pitch;
            sound.aSrc.loop = sound.loop;
        }
    }

    void Start()
    {
        PlaySound("River");
        PlaySound("Forest");
    }

    public void PlaySound(string name)
    {
        Sound sound = Array.Find(soundArr, s => s.name == name);
        if (sound == null)
        {
            Debug.LogWarning("AudioManager: " + name + " cannot be found");
            return;
        }
        sound.aSrc.Play();
    }

    public void Resume()
    {
        foreach (Sound sound in soundArr)
            sound.aSrc.UnPause();
    }

    public void Pause()
    {
        foreach (Sound sound in soundArr)
            sound.aSrc.Pause();
    }
}
