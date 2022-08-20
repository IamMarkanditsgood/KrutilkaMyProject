using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingPanel : MonoBehaviour
{
    [SerializeField] private GameObject _musicObj;
    [SerializeField] private ClickButtonSound _clickScript;
    private AudioSource _audioSourceMusic;
    private float _musicVolume = 1f;
    private float _soundVolume = 1f;
    private float _rotation = 1f;

    private void Start()
    {
        _audioSourceMusic = _musicObj.GetComponent<AudioSource>();
    }
    private void Update()
    {
        _audioSourceMusic.volume = _musicVolume;
    }
    public void SliderOfMusic(float MusicVol)
    {
        
        _musicVolume = MusicVol;
    }
    public void SliderOfSounds(float SoundVol)
    {
        _soundVolume = SoundVol;
    }
    public void SliderOfRotation(float Rotation)
    {
        _rotation = Rotation;
    }
    public void ClosePanel()
    {
        _clickScript.ClickSound();
        PlayerPrefs.SetFloat("MusicVolume", _musicVolume);
        PlayerPrefs.SetFloat("SoundsVolume", _soundVolume);
        PlayerPrefs.SetFloat("RotationValue", _rotation);
        gameObject.SetActive(false);
        
    }
}
