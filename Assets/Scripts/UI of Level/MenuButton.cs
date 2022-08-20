using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    [SerializeField] private ClickButtonSound _sound;
    public void PressToMenu()
    {
        _sound.ClickSound();
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
