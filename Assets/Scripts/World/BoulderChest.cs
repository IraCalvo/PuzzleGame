using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderChest : MonoBehaviour
{
    public void onOpenChest()
    {
        PlayerPrefs.SetInt("boulderLevelComplete", PlayerPrefs.GetInt("boulderLevelComplete", 0) + 1);
        PlayerController.instance.AddKey();
        Destroy(gameObject);
    }
}
