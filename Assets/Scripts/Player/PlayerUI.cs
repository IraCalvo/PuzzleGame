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

    public GameObject key1;
    public GameObject key2;
    public GameObject key3;

    void Awake()
    {
        playerController = FindObjectOfType<PlayerController>();
        instance = this;
    }

    void Update()
    {
        if(PlayerPrefs.GetInt("keyCount") == 1)
        {
            key1.gameObject.SetActive(true);
        }
        if(PlayerPrefs.GetInt("keyCount") == 2)
        {
            key1.gameObject.SetActive(true);
            key2.gameObject.SetActive(true);
        }
        if(PlayerPrefs.GetInt("keyCount") == 3)
        {
            key1.gameObject.SetActive(true);
            key2.gameObject.SetActive(true);
            key3.gameObject.SetActive(true);
        }

        Debug.Log("Player currently has:" + PlayerPrefs.GetInt("keyCount") + " Keys");

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
}
