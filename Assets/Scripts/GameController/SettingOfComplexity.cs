using UnityEngine;

public class SettingOfComplexity : MonoBehaviour
{ 
    [SerializeField] private int _levelOfComlexity;
    private int _nextCase = 0;

    private void Start()
    {
        LevelOfComplexety(_levelOfComlexity);
    }
    private void Update()
    {
        if (DataForLevels.GetDatas.ScoreInCurrentLevel == 2 && _nextCase == 0)
        { 
            DataForLevels.GetDatas.LevelComplexity++;
            ChangeSpeed(1.5f);
            ChangeTimeForSpavn(5.5f);
            TimeForTeleport(2.5f);
            LengthForRaycastLine(3f);
            _nextCase++;
        }
        else if (DataForLevels.GetDatas.ScoreInCurrentLevel == 5 && _nextCase == 1)
        {
            DataForLevels.GetDatas.LevelComplexity++;
            ChangeSpeed(2);
            ChangeTimeForSpavn(5);
            TimeForTeleport(2.5f);
            LengthForRaycastLine(3f);
            _nextCase++;
        }
        else if (DataForLevels.GetDatas.ScoreInCurrentLevel == 10 && _nextCase == 2)
        {
            DataForLevels.GetDatas.LevelComplexity++;
            ChangeSpeed(3);
            ChangeTimeForSpavn(3.5f);
            TimeForTeleport(2f);
            LengthForRaycastLine(3f);
            _nextCase++;
        }
        else if (DataForLevels.GetDatas.ScoreInCurrentLevel == 15 && _nextCase == 3)
        {
            ChangeSpeed(3.5f);
            ChangeTimeForSpavn(3);
            TimeForTeleport(1.5f);
            LengthForRaycastLine(3f);
            _nextCase++;
        }
        else if (DataForLevels.GetDatas.ScoreInCurrentLevel == 20 && _nextCase == 4)
        {
            ChangeSpeed(4);
            ChangeTimeForSpavn(2.5f);
            TimeForTeleport(1.5f);
            LengthForRaycastLine(3f);
            _nextCase++;
        }
        else if (DataForLevels.GetDatas.ScoreInCurrentLevel == 30 && _nextCase == 5)
        {
            ChangeSpeed(5);
            ChangeTimeForSpavn(2);
            TimeForTeleport(1f);
            LengthForRaycastLine(2.5f);
            _nextCase++;
        }
        else if (DataForLevels.GetDatas.ScoreInCurrentLevel == 50 && _nextCase == 6)
        {
            ChangeSpeed(6);
            ChangeTimeForSpavn(1.5f);
            TimeForTeleport(0.8f);
            LengthForRaycastLine(3f);
            _nextCase++;
        }
        else if (DataForLevels.GetDatas.ScoreInCurrentLevel == 80 && _nextCase == 7)
        {
            ChangeSpeed(6.5f);
            ChangeTimeForSpavn(1);
            TimeForTeleport(0.5f);
            LengthForRaycastLine(3.2f);
            _nextCase++;
        }
        else if (DataForLevels.GetDatas.ScoreInCurrentLevel == 110 && _nextCase == 8)
        {
            ChangeSpeed(7);
            ChangeTimeForSpavn(1);
            TimeForTeleport(0.5f);
            LengthForRaycastLine(2.5f);
            _nextCase++;
        }
        else if (DataForLevels.GetDatas.ScoreInCurrentLevel == 200 && _nextCase == 9)
        {
            ChangeSpeed(8);
            ChangeTimeForSpavn(1);
            TimeForTeleport(0.5f);
            LengthForRaycastLine(3.5f);
            _nextCase++;
        }
        else if (DataForLevels.GetDatas.ScoreInCurrentLevel == 600 && _nextCase == 10)
        {

            TimeForTeleport(0.3f);
            LengthForRaycastLine(4.5f);
            DataForLevels.GetDatas.SpeedForObjects+=0.5f;
            _nextCase++;
        }
        else if(DataForLevels.GetDatas.ScoreInCurrentLevel == 1200 && _nextCase == 11)
        {
            TimeForTeleport(0.1f);
            LengthForRaycastLine(4.5f);
            ChangeSpeed(10f);
            _nextCase++;
        }
        else if (DataForLevels.GetDatas.ScoreInCurrentLevel == 3000 && _nextCase == 12)
        {
            TimeForTeleport(0.1f);
            LengthForRaycastLine(3f);
            ChangeSpeed(10f);
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
    private void LengthForRaycastLine(float value)
    {
        DataForLevels.GetDatas.LengthOfRaycast = value;
    }
    private void LevelOfComplexety(int value)
    {
        switch (value)
        {
            case 0:
                break;
            case 1:
                
                DataForLevels.GetDatas.ScoreInCurrentLevel = 2;
                _nextCase = 0;
                break;
            case 2:
                DataForLevels.GetDatas.LevelComplexity = 1;
                DataForLevels.GetDatas.ScoreInCurrentLevel = 5;
                _nextCase = 1;
                break;
            case 3:
                DataForLevels.GetDatas.LevelComplexity = 2;
                DataForLevels.GetDatas.ScoreInCurrentLevel = 10;
                _nextCase = 2;
                break;
            case 4:
                DataForLevels.GetDatas.LevelComplexity = 3;
                DataForLevels.GetDatas.ScoreInCurrentLevel = 15;
                _nextCase = 3;
                break;
            case 5:
                DataForLevels.GetDatas.LevelComplexity = 4;
                DataForLevels.GetDatas.ScoreInCurrentLevel = 20;
                _nextCase = 4;
                break;
            case 6:
                DataForLevels.GetDatas.LevelComplexity = 4;
                DataForLevels.GetDatas.ScoreInCurrentLevel = 30;
                _nextCase = 5;
                break;
            case 7:
                DataForLevels.GetDatas.LevelComplexity = 4;
                DataForLevels.GetDatas.ScoreInCurrentLevel = 50;
                _nextCase = 6;
                break;
            case 8:
                DataForLevels.GetDatas.LevelComplexity = 4;
                DataForLevels.GetDatas.ScoreInCurrentLevel = 80;
                _nextCase = 7;
                break;
            case 9:
                DataForLevels.GetDatas.LevelComplexity = 4;
                DataForLevels.GetDatas.ScoreInCurrentLevel = 110;
                _nextCase = 8;
                break;
            case 10:
                DataForLevels.GetDatas.LevelComplexity = 4;
                DataForLevels.GetDatas.ScoreInCurrentLevel = 200;
                _nextCase = 9;
                break;
            case 11:
                ChangeSpeed(8);
                ChangeTimeForSpavn(1);
                DataForLevels.GetDatas.LevelComplexity = 4;
                DataForLevels.GetDatas.ScoreInCurrentLevel = 600;
                _nextCase = 10;
                break;
            case 12:
                ChangeSpeed(8.5f);
                ChangeTimeForSpavn(1);
                DataForLevels.GetDatas.LevelComplexity = 4;
                DataForLevels.GetDatas.ScoreInCurrentLevel = 1200;
                _nextCase = 11;
                break;
        }

    }
}
