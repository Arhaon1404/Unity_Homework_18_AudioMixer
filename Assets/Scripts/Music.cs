using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class Music : MonoBehaviour
{
    [SerializeField] private MusicSwitcher _musicSwitcher;
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        _musicSwitcher.ButtonClicked += SwitchMusicState;
    }

    private void OnDisable()
    {
        _musicSwitcher.ButtonClicked -= SwitchMusicState;
    }

    private void SwitchMusicState()
    {
        _audioSource.enabled = _audioSource.enabled == true ? false : true;
    }
}