using UnityEngine;
using UnityEngine.UI;

public class pause : MonoBehaviour
{
    [SerializeField] private Sprite _pauseOff, _pauseOn;
    [SerializeField] private GameObject _buttonPause;
    [SerializeField] private ClickButtonSound _sound;
    private bool _isPause = true;

    public void pressPause()
    {
        _sound.ClickSound();
        if (_isPause)
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
