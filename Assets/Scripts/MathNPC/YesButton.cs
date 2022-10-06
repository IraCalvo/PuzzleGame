using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YesButton : MonoBehaviour
{
    public GameObject questionBox;
    public GameObject DialogBox;

    public void OnButtonPress()
    {
        DialogBox.SetActive(false);
        questionBox.SetActive(true);
    }
}
