using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButtonSound : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _soundOfClick;
    private void Update()
    {
        _audioSource.volume = PlayerPrefs.GetFloat("SoundsVolume");
    }
    public void ClickSound()
    {
        _audioSource.PlayOneShot(_soundOfClick);
    }
}
