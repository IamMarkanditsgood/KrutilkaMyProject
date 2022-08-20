using UnityEngine;
using TMPro;

public class CapabilityShield : MonoBehaviour
{
    [SerializeField] private float _finishTime;
    [SerializeField] private GameObject _shieldTimer;
    [SerializeField] private TMP_Text _timerText;
    private float _curentTime;
    private float _timer = 6;
    private void Update()
    {
        _curentTime += Time.deltaTime;
        _timer -= Time.deltaTime;
        int toint = (int)_timer;
        _timerText.text = toint.ToString();
        if(_curentTime >= _finishTime)
        {
            _curentTime = 0;
            _timer = 6;
            DataForLevels.GetDatas.IsShieldActive = false;
            _shieldTimer.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
