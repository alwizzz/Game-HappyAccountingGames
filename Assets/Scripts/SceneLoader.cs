using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : SingletonMonoBehaviour<SceneLoader>
{
    public void QuitGame()
    {
        Application.Quit();
    }
}
