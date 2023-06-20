using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SummaryData")]
public class SummaryData : ScriptableObject
{
    public int index;
    public string title;
    [TextArea(4, 10)] public string content;
}
