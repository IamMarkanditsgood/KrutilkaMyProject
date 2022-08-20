using UnityEngine;
using TMPro;

public class ScoreInText : MonoBehaviour
{
    [SerializeField] private TMP_Text  TextForScore;

    private void Start()
    {
        TextForScore.text = $"Best score: \n{ PlayerPrefs.GetInt("BestScore")}";
    }
}
