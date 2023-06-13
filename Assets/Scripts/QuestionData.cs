using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "QuestionData")]
public class QuestionData : ScriptableObject
{
    [SerializeField] [TextArea(2, 4)] private string question;


    public enum AnswerOption
    {
        TRUE,
        FALSE
    }

    [SerializeField] private AnswerOption correctOption;


    public string GetQuestion() => question;

    public AnswerOption GetCorrectOption() => correctOption;

}

    //[Tooltip("If checked then option captions would be 'True' and 'False' respectfully" +
    //    " AND shuffle would be false")]
    //[SerializeField] private bool booleanAnswer = true;

    //[Tooltip("If checked then the correct and wrong answers might be switched")]
    //[SerializeField] private bool shuffle = false;

    //[SerializeField] private string option1Caption = "True";
    //[SerializeField] private string option2Caption = "False";
    
    //public string GetOption1Caption()
    //{
    //    if (booleanAnswer)
    //    {
    //        return "True";
    //    } else
    //    {
    //        return option1Caption;
    //    }
    //}
    //public string GetOption2Caption()
    //{
    //    if (booleanAnswer)
    //    {
    //        return "False";
    //    }
    //    else
    //    {
    //        return option2Caption;
    //    }
    //}

    //public bool Shuffle()
    //{
    //    if (booleanAnswer)
    //    {
    //        return false;
    //    } else
    //    {
    //        return shuffle;
    //    }
    //}