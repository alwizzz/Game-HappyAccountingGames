using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelButton : MonoBehaviour
{
    [SerializeField] private int levelIndex;
    [SerializeField] private GameObject lockedPrefab;
    [SerializeField] private GameObject unlockedPrefab;



    public int GetLevelIndex() => levelIndex;
    public void Activate(bool activate)
    {
        //TODO: implement button when activated and inactivated
        if(activate)
        {
            GetComponent<Button>().interactable = true;

            lockedPrefab.SetActive(false);
            unlockedPrefab.SetActive(true);
        }
        else
        {
            GetComponent<Button>().interactable = false;

            lockedPrefab.SetActive(true);
            unlockedPrefab.SetActive(false);
        }
    }

    public void OnClick()
    {
        FindObjectOfType<SceneLoader>().LoadLevelScene(levelIndex);
    }

}
