using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    public int playerLevelProgress = 0;

    [System.Serializable]
    public class LevelProgress
    {
        public LevelData level;
        public int highestScore;
    }

    public List<LevelProgress> levelProgresses;
    public List<SummaryData> summaryDataList;

    [Header("Inter-scene Cache")]
    public int currentLevel;
    public int currentSummary;


    protected override void Awake()
    {
        base.Awake();
        //TODO: refresh Inter scene cache if not used
    }

    public LevelData GetCurrentLevel()
    {
        LevelData levelData = null;
        foreach(LevelProgress data in levelProgresses)
        {
            if(data.level.GetLevelIndex() == currentLevel)
            {
                levelData = data.level;
                break;
            }
        }

        if(levelData == null)
        {
            print("Level not found!, returning level on the first index instead");
            levelData = levelProgresses[0].level;
        }

        return levelData;
    }

    public SummaryData GetCurrentSummary()
    {
        SummaryData summaryData = null;
        foreach(SummaryData dt in summaryDataList)
        {
            if(dt.index == currentSummary)
            {
                summaryData = dt;
                break;
            }
        }

        if(summaryData == null)
        {
            print("Summary not found!, returning level on the first index instead");
            summaryData = summaryDataList[0];
        }

        return summaryData;
    }

    public void UpdateScore(int levelIndex, int scorePoint)
    {
        foreach(LevelProgress lp in levelProgresses)
        {
            if(lp.level.GetLevelIndex() == levelIndex)
            {
                if(scorePoint > lp.highestScore)
                {
                    print("New highscore of " + lp.level + ": " + scorePoint);
                } else
                {
                    print("New score " + scorePoint + " is less or equal than highest score " + lp.highestScore);
                }
            }
        }
    }

    public void StartGame()
    {
        FindObjectOfType<SceneLoader>().LoadLevelListScene();
    }

    public void ContinueGame()
    {
        FindObjectOfType<SceneLoader>().LoadLevelListScene();
    }

}
