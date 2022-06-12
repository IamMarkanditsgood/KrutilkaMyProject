using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pause : MonoBehaviour
{
    private bool _isPause = true;
    [SerializeField] private Sprite _pauseOff, _pauseOn;
    [SerializeField] private GameObject _buttonPause;
    public void pressPause()
    {
        if(_isPause)
        {
            _buttonPause.GetComponent<Image>().sprite = _pauseOff;
            _isPause = false;
            Time.timeScale = 0f;
        }
        else
        {
            _buttonPause.GetComponent<Image>().sprite = _pauseOn;
            _isPause = true;
            Time.timeScale = 1f;
        }
    }
}
