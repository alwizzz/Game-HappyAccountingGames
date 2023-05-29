using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    public List<LevelData> levels;
    public int playerLevelProgress = 0;
}
