using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoButton : MonoBehaviour
{
    public GameObject dialogBox;

    public void OnButtonClick()
    {
        dialogBox.SetActive(false);
        PlayerController.instance.PlayerCanMoveAgain();
    }
}
