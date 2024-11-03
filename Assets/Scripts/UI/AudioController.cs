using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
    public AudioMixer audioMixer;
    public AudioMixerSnapshot audioMixerSnapshot;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("MusicVolume", volume);
    }

    public void PauseGame()
    {
        audioMixerSnapshot.TransitionTo(2f);
    }
}
