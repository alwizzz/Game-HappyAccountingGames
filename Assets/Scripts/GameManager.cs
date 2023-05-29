using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    public List<LevelData> levels;
    public int playerLevelProgress = 0;

    [Header("Inter-scene Cache")]
    public LevelData currentLevelData;

    protected override void Awake()
    {
        base.Awake();
        //TODO: refresh Inter scene cache if not used
    }

}
