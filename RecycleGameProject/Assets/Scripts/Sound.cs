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
    public float volume;
    [Range(0.1f, 1.0f)]
    public float pitch;

}
