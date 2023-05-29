using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "LevelData")]
public class LevelData : ScriptableObject
{
    [SerializeField] private int levelIndex;
    [SerializeField] [TextArea(2, 4)] private string description;
    [SerializeField] private List<QuestionData> questionList;

    public int GetLevelIndex() => levelIndex;
}
