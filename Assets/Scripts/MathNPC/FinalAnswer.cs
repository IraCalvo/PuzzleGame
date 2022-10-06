using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalAnswer : MonoBehaviour
{
    public GameObject wall;
    public GameObject finalMessage;
    public GameObject previousQuestion;

    public void OnButtonPress()
    {
        StartCoroutine(OnButtonClick());
    }

    IEnumerator OnButtonClick()
    {
        finalMessage.SetActive(true);
        yield return new WaitForSeconds(3f);
        wall.SetActive(false);
        finalMessage.SetActive(false);
        previousQuestion.SetActive(false);
        PlayerController.instance.PlayerCanMoveAgain();
    }
}
