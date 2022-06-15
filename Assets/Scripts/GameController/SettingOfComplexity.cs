using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingOfComplexity : MonoBehaviour
{
    [SerializeField] private int _nextCase;
    private void Update()
    {
        if (DataForLevels.GetDatas.ScoreInCurrentLevel == 5 && _nextCase == 0)
        {
               
            DataForLevels.GetDatas.LevelComplexity++;
            ChangeSpeed(1.5f);
            ChangeTimeForSpavn(5.5f);
            TimeForTeleport(2.5f);
            _nextCase++;
        }
        else if (DataForLevels.GetDatas.ScoreInCurrentLevel == 10 && _nextCase == 1)
        {
            DataForLevels.GetDatas.LevelComplexity++;
            ChangeSpeed(2);
            ChangeTimeForSpavn(5);
            _nextCase++;
        }
        else if (DataForLevels.GetDatas.ScoreInCurrentLevel == 20 && _nextCase == 2)
        {
            DataForLevels.GetDatas.LevelComplexity++;
            ChangeSpeed(3);
            ChangeTimeForSpavn(3.5f);
            _nextCase++;
        }
        else if (DataForLevels.GetDatas.ScoreInCurrentLevel == 30 && _nextCase == 3)
        {
            ChangeSpeed(3.5f);
            ChangeTimeForSpavn(3);
            TimeForTeleport(2.2f);
            _nextCase++;
        }
        else if (DataForLevels.GetDatas.ScoreInCurrentLevel == 40 && _nextCase == 4)
        {
            ChangeSpeed(4);
            ChangeTimeForSpavn(2.5f);
            TimeForTeleport(1.8f);
            _nextCase++;
        }
        else if (DataForLevels.GetDatas.ScoreInCurrentLevel == 50 && _nextCase == 5)
        {
            ChangeSpeed(5);
            ChangeTimeForSpavn(2);
            TimeForTeleport(1.9f);
            _nextCase++;
        }
        else if (DataForLevels.GetDatas.ScoreInCurrentLevel == 60 && _nextCase == 6)
        {
            ChangeSpeed(6);
            ChangeTimeForSpavn(1.5f);
            _nextCase++;
        }
        else if (DataForLevels.GetDatas.ScoreInCurrentLevel == 70 && _nextCase == 7)
        {
            ChangeSpeed(6.5f);
            ChangeTimeForSpavn(1);
            _nextCase++;
        }
        else if (DataForLevels.GetDatas.ScoreInCurrentLevel == 85 && _nextCase == 8)
        {
            ChangeSpeed(7);
            ChangeTimeForSpavn(1);
            _nextCase++;
        }
        else if (DataForLevels.GetDatas.ScoreInCurrentLevel == 100 && _nextCase == 9)
        {
            ChangeSpeed(8);
            ChangeTimeForSpavn(1);
            TimeForTeleport(1.5f);
            _nextCase++;
        }
        else if (DataForLevels.GetDatas.ScoreInCurrentLevel == 200 && _nextCase == 10)
        {
            TimeForTeleport(1.2f);
            DataForLevels.GetDatas.SpeedForObjects+=0.5f;
            _nextCase++;
        }
        
        
    }
    private void ChangeSpeed(float value)
    {
        DataForLevels.GetDatas.SpeedForObjects = value;
    }
    private void ChangeTimeForSpavn(float value)
    {
        DataForLevels.GetDatas.TimeForSpavn = value;
    }
    private void TimeForTeleport(float value)
    {
        DataForLevels.GetDatas.TimeForChangingPosition = value;
    }

}
