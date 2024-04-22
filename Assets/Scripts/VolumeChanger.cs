using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeChanger : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixerGroup;

    public void VolumeChange(float volume)
    {
        _audioMixerGroup.audioMixer.SetFloat(_audioMixerGroup.name, Mathf.Log10(volume) * 20);
    }
}
