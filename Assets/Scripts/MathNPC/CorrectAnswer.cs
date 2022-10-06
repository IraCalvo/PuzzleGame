using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAnswer : MonoBehaviour
{
    public GameObject nextQuestionBox;
    public GameObject previousQuestionBox;

    public void OnButtonPress()
    {
        nextQuestionBox.SetActive(true);
        previousQuestionBox.SetActive(false);
    }
}
