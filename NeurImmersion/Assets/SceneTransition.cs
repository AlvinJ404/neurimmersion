using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public GameObject StartScreen;
    public GameObject MLPScreen1;
    public GameObject ReLUScreen1;
    public GameObject ReLUScreen2;
    public GameObject ReLUScreen3;
    public GameObject CorrectAnswerText;
    public GameObject IncorrectAnswerText;

    public void LoadMLPScene1()
    {
        StartScreen.SetActive(false); 
        MLPScreen1.SetActive(true);
    }

    public void LoadReLUScreen1()
    {
        MLPScreen1.SetActive(false);
        ReLUScreen1.SetActive(true);
    }

    public void LoadReLUScreen2()
    {
        ReLUScreen1.SetActive(false);
        ReLUScreen2.SetActive(true);
    }

    public void LoadReLUScreen3()
    {
        ReLUScreen2.SetActive(false);
        ReLUScreen3.SetActive(true);
    }


    public void ReturnToStartScreen()
    {
        ReLUScreen2.SetActive(false);
        ReLUScreen3.SetActive(false);
        StartScreen.SetActive(true);
    }

    public void CorrectAnswer()
    {
        CorrectAnswerText.SetActive(false);
        IncorrectAnswerText.SetActive(false);
        CorrectAnswerText.SetActive(true);
    }

    public void IncorrectAnswer()
    {
        CorrectAnswerText.SetActive(false);
        IncorrectAnswerText.SetActive(false);
        IncorrectAnswerText.SetActive(true);
    }
}
