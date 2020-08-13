using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManagerScript : MonoBehaviour
{

    public AudioMixerGroup audioMixer;
    public Sound[] soundArr;

    void Awake()
    {
        foreach(Sound sound in soundArr)
        {
            sound.aSrc = this.gameObject.AddComponent<AudioSource>();
            sound.aSrc.outputAudioMixerGroup = audioMixer;
            sound.aSrc.clip = sound.audioClip;
            //sound.aSrc.volume = sound.volume;
            sound.aSrc.pitch = sound.pitch;
        }
    }

    public void PlaySound(string name)
    {
        Sound sound = Array.Find(soundArr, s => s.name == name);
        sound.aSrc.Play();
    }
}
