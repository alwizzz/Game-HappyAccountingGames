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

    public void LoadLevelScene(LevelData data)
    {
        GameManager.Instance.currentLevelData = data;
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
