using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicInLevel : MonoBehaviour
{
    private AudioSource _musicSource;
    private void Start()
    {
        _musicSource = GetComponent<AudioSource>();
        _musicSource.volume = DataForLevels.GetDatas.MusicVolume;
    }
}
