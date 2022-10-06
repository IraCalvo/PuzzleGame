using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{

    public GameObject key;

    public void OnOpenChest()
    {
        PlayerController.instance.AddKey();
        PlayerUI.instance.KeyAdded();
        key.SetActive(true);
        Destroy(gameObject);
    }
}
