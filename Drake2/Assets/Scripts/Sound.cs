using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound 
{
    //every object of the sound class has a name
    [SerializeField] protected string SfxName;
    public string GetName() { return SfxName; }


    //every object of the sound class has an audio file associated with it
    [SerializeField] protected AudioClip sound;
    public AudioClip GetSound() { return sound; }


    //allows for volume to be changed in unity editor
    [Range(0f, 1f)]
    [SerializeField] protected float volume;
    public float GetVolume() { return volume; }


    //allows for pitch to be changed in unity editor
    [Range(0.1f, 3f)]
    [SerializeField] protected float pitch;
    public float GetPitch() { return pitch; }


    //connects to audio manager
    private AudioSource source;
    public void SetSource(AudioSource s) { source = s; }
    public AudioSource GetSource() { return source; }


    //music plays at the start of run
    public bool playOnAwake;

    //loops music
    public bool loop;

}
