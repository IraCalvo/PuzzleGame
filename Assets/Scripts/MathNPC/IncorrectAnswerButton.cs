using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncorrectAnswerButton : MonoBehaviour
{

    public GameObject incorrectAnswerBox;
    public GameObject questionBox;

    public void OnButtonPress()
    {
        StartCoroutine(OnButtonClick());
    }


    private IEnumerator OnButtonClick()
    {
        
        incorrectAnswerBox.SetActive(true);
        Debug.Log("Can you see this one?");
        yield return new WaitForSeconds(3);
        questionBox.SetActive(false);
        Debug.Log("Can you see this?");
        incorrectAnswerBox.SetActive(false);
        Debug.Log("See this one?");
        PlayerController.instance.PlayerCanMoveAgain();
    }
}
