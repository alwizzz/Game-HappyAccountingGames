using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadLevelScene(int levelIndex)
    {
        GameManager.Instance.currentLevel = levelIndex;
        SceneManager.LoadScene("Level");
    }

    public void LoadLevelListScene()
    {
        SceneManager.LoadScene("LevelList");
    }

    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadTitleScreenScene()
    {
        SceneManager.LoadScene("TitleScreen");
    }
    public void LoadSummaryListScene()
    {
        SceneManager.LoadScene("SummaryList");
    }

    public void LoadSummaryScene(int summaryIndex)
    {
        GameManager.Instance.currentSummary = summaryIndex;
        SceneManager.LoadScene("Summary");
    }

    public void StartGame()
    {
        //TODO: GameManager stuff
        LoadLevelListScene();
    }

    public void ContinueGame()
    {
        //TODO: GameManager stuff
        LoadLevelListScene();
    }
}
