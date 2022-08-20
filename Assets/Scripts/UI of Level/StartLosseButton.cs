using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartLosseButton : MonoBehaviour
{
    [SerializeField] private GameObject _button;
    [SerializeField] private List <GameObject> UIObjects;
    [SerializeField] private TMP_Text _text;
    [SerializeField] private ClickButtonSound _sound;
    public static StartLosseButton startLosseButton;

    private void Awake()
    {
        startLosseButton = this;
        _text.text = "Tap the screen to play";
    }
    public void PressingButton()
    {
        _sound.ClickSound();
        if (DataForLevels.GetDatas.StateOfLevel == false)
        {

            SceneManager.LoadScene(1, LoadSceneMode.Single);
        }
        else
        {
            Time.timeScale = 1;
            for(int i = 0; i < UIObjects.Count; i++)
            {
                UIObjects[i].SetActive(true);
            }
            _button.gameObject.SetActive(false);
        }
    }
    public void LoadLosseMenu()
    {
        for (int i = 0; i < UIObjects.Count; i++)
        {
            UIObjects[i].SetActive(false);
        }
        _text.text = "Tap the screen to restart level";
        _button.gameObject.SetActive(true);
    }
}
