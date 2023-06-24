using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelMaster : MonoBehaviour
{
    [SerializeField] private int levelIndex;

    [SerializeField] private int scorePoint;
    [SerializeField] private TMP_Text scoreText;

    [SerializeField] private bool isWaitingForAnswer;


    [SerializeField] private LevelData levelData;
    [SerializeField] private List<QuestionData> questionList;

    [SerializeField] private int questionIndex = 0;
    [SerializeField] private QuestionData currentQuestion;
    [SerializeField] private TMP_Text questionText;
    [SerializeField] private TMP_Text questionNumberText;



    private void Awake()
    {
        levelIndex = GameManager.Instance.currentLevel;
        levelData = GameManager.Instance.GetCurrentLevel();
        questionList = levelData.GetQuestionList();
    }

    private void Start()
    {
        Setup();
        StartGame();
    }

    private void Setup()
    {
        scorePoint = 0;
        UpdateScoreText();

        isWaitingForAnswer = false;
    }

    #region UI Updates

    private void UpdateScoreText()
    {
        scoreText.text = "Poin = " + scorePoint.ToString();
    }

    private void UpdateQuestionText()
    {
        questionText.text = currentQuestion.GetQuestion();
        questionNumberText.text = "Question No." + (questionIndex + 1).ToString();
    }

    #endregion

    #region Level Flow

    private void StartGame()
    {
        questionIndex = -1;
        NextQuestion();
    }

    private void NextQuestion()
    {
        questionIndex++;
        if(questionIndex > questionList.Count - 1)
        {
            FinishGame();
            return;
        }

        currentQuestion = questionList[questionIndex];
        UpdateQuestionText();

        isWaitingForAnswer = true;
    }

    private void FinishGame()
    {
        print("Game is finished");
        GameManager.Instance.UpdateScore(levelIndex, scorePoint);
    }

    #endregion

    #region Answer Mechanic


    public void AnswerTrue()
    {
        if (!isWaitingForAnswer) { return; }
        //print("answer true");

        StartCoroutine(Answer(QuestionData.AnswerOption.TRUE));
    }

    public void AnswerFalse()
    {
        if (!isWaitingForAnswer) { return; }
        //print("answer false");

        StartCoroutine(Answer(QuestionData.AnswerOption.FALSE));
    }

    private IEnumerator Answer(QuestionData.AnswerOption answer)
    {
        bool isCorrect = CheckAnswer(answer);

        if (isCorrect) {
            scorePoint++;
            UpdateScoreText();
        }

        isWaitingForAnswer = false;

        print("==============Answer is " + (isCorrect ? "correct!" : "wrong!"));
        yield return new WaitForSeconds(3f);

        NextQuestion();        
    }

    private bool CheckAnswer(QuestionData.AnswerOption answer)
    {
        if(answer == currentQuestion.GetCorrectOption())
        {
            return true;
        } else
        {
            return false;
        }
    }

    #endregion


}
