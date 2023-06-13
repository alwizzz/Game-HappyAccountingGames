using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : SingletonMonoBehaviour<SceneLoader>
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
}
