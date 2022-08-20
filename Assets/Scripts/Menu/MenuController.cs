using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject _settingPanel;
    [SerializeField] private GameObject _sliderMusic;
    [SerializeField] private GameObject _sliderSound;
    [SerializeField] private GameObject _sliderRotation;
    [SerializeField] private GameObject _musicObject;
    [SerializeField] private ClickButtonSound _buttonSound;
    private Slider _sliderM;
    private Slider _sliderS;
    private Slider _sliderR;
    private AudioSource _audioSourceMusic;
    private void Awake()
    {
        FirstDownload();    
    }
    private void Start()
    {
        _audioSourceMusic = _musicObject.GetComponent<AudioSource>();
        _sliderM = _sliderMusic.GetComponent<Slider>();
        _sliderS = _sliderSound.GetComponent<Slider>();
        _sliderR = _sliderRotation.GetComponent<Slider>();
        _audioSourceMusic.volume = PlayerPrefs.GetFloat("MusicVolume");
        _sliderM.value = PlayerPrefs.GetFloat("MusicVolume");
        _sliderS.value = PlayerPrefs.GetFloat("SoundsVolume");
        _sliderR.value = PlayerPrefs.GetFloat("RotationValue");
    }
    private void FirstDownload()
    {
        if (!PlayerPrefs.HasKey("MusicVolume"))
        {
            PlayerPrefs.SetFloat("MusicVolume", 0.5f);
        }
        if (!PlayerPrefs.HasKey("SoundsVolume"))
        {
            PlayerPrefs.SetFloat("SoundsVolume", 0.5f);
        }
        if (!PlayerPrefs.HasKey("RotationValue"))
        {
            PlayerPrefs.SetFloat("RotationValue", 0.5f);
        }
    }
    public void PressPlay()
    {
        _buttonSound.ClickSound();
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
    public void PressExit()
    {
        _buttonSound.ClickSound();
        Application.Quit();
    }
    public void PressSettings()
    {
        _buttonSound.ClickSound();
        _settingPanel.SetActive(true);
    }

}
