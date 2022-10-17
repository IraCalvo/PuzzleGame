using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mathChest : MonoBehaviour
{
    public void onOpenChest()
    {
        PlayerPrefs.SetInt("mathLevelComplete", PlayerPrefs.GetInt("mathLevelComplete", 0) + 1);
        PlayerController.instance.AddKey();
        Destroy(gameObject);
    }
}
