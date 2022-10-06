using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public TextMeshProUGUI interactText;

    private PlayerController playerController;

    public static PlayerUI instance;

    void Awake()
    {
        playerController = FindObjectOfType<PlayerController>();
        instance = this;
    }

    public void SetInteractText(Vector3 pos, string text)
    {
        interactText.gameObject.SetActive(true);
        interactText.text = text;

        interactText.transform.position = Camera.main.WorldToScreenPoint(pos + Vector3.up);
    }

    public void DisableInteractText()
    {
        if(interactText.gameObject.activeInHierarchy)
            interactText.gameObject.SetActive(false);
    }

    public void KeyAdded()
    {

    }

}
