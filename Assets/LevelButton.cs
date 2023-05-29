using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelButton : MonoBehaviour
{
    [SerializeField] private LevelData data;

    public LevelData GetLevelData() => data;

    public void Activate(bool activate)
    {
        //TODO: implement button when activated and inactivated
    }

    public void OnClick()
    {
        SceneLoader.Instance.LoadLevelScene(data);
    }

}
