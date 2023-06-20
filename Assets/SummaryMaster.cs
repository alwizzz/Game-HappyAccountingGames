using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SummaryMaster : MonoBehaviour
{
    [SerializeField] private SummaryData summaryData;

    [SerializeField] private TMP_Text titleText;
    [SerializeField] private TMP_Text contentText;


    private void Start()
    {
        summaryData = GameManager.Instance.GetCurrentSummary();

        titleText.text = summaryData.title;
        contentText.text = summaryData.content;
    }

}
