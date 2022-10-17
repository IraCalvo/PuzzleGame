using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverChest : MonoBehaviour
{
    public void onOpenChest()
    {
        PlayerPrefs.SetInt("leverLevelComplete", PlayerPrefs.GetInt("leverLevelComplete", 0) + 1);
        PlayerController.instance.AddKey();
        Destroy(gameObject);
    }
}

