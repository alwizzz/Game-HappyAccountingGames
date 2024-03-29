using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelListManager : MonoBehaviour
{
    [SerializeField] private List<LevelButton> levelButtons;

    private void Awake()
    {
        SetupLevelButtons();
    }

    private void SetupLevelButtons()
    {
        int levelProgress = GameManager.Instance.playerLevelProgress;
        levelButtons.ForEach(levelButton =>
        {
            var levelIndex = levelButton.GetLevelIndex();
            if (levelIndex <= levelProgress)
            {
                levelButton.Activate(true);
            }
            else
            {
                levelButton.Activate(false);
            }
        });
    }

}
