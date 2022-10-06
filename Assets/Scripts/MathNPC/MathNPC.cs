using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathNPC : MonoBehaviour
{
    public GameObject dialogBox;

    public void WhenTalkedTo()
    {
        dialogBox.SetActive(true);
        PlayerController.instance.PlayerCannotMove();
    }
}
