using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    public string name;
    public AudioClip audioClip;

    [HideInInspector]
    public AudioSource aSrc;

    [Range(0.0f, 1.0f)]
    public float volume = 1.0f;
    [Range(0.1f, 2.0f)]
    public float pitch = 1.0f;

    public bool loop;
}
