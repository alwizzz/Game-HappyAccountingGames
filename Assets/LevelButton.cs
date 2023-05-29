using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelButton : MonoBehaviour
{
    [SerializeField] private LevelData data;

    public LevelData GetLevelData() => data;

}
