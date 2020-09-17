using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerSideScript : MonoBehaviour {

    private static readonly string BackgroundPref = "BackgroundPref";
    private static readonly string SoundEffectPref = "SoundEffectPref";
    private float backgroundFloat, soundEffectsFloat;
    public AudioSource backgroundAudio;
    public AudioSource soundEffectsAudio; 

    // Use this for initialization
    void Awake()
    {
        ContinueSettings();
    }

    public void ContinueSettings()
    {
        backgroundFloat = PlayerPrefs.GetFloat(BackgroundPref);
        //Debug.Log(backgroundFloat);

        soundEffectsFloat = PlayerPrefs.GetFloat(SoundEffectPref);

        backgroundAudio.volume = backgroundFloat;
        soundEffectsAudio.volume = soundEffectsFloat;


    }

    public void PlaySE()
    {
        soundEffectsAudio.Play();
    }
}
