using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelButton : MonoBehaviour
{
    [SerializeField] private int levelIndex;


    public int GetLevelIndex() => levelIndex;
    public void Activate(bool activate)
    {
        //TODO: implement button when activated and inactivated
    }

    public void OnClick()
    {
        SceneLoader.Instance.LoadLevelScene(levelIndex);
    }

}
