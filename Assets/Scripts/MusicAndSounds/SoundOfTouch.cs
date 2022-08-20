using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOfTouch : MonoBehaviour
{
    public static SoundOfTouch instance;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _soundOfTouch;
    private void Awake()
    {
        instance = this;
    }
    public void DoSound()
    {
        _audioSource.PlayOneShot(_soundOfTouch);
    }
}
