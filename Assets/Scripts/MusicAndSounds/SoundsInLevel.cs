using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsInLevel : MonoBehaviour
{
    private AudioSource _soundSource;
    private void Start()
    {
        _soundSource = GetComponent<AudioSource>();
        _soundSource.volume = DataForLevels.GetDatas.SoundsVolume;
    }
}
