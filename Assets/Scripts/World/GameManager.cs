using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject mathChest;
    public GameObject mathNPC;
    public GameObject leverChest;
    public GameObject boulderChest;

    void Start()
    {
        Debug.Log("GameManager Start: PlayerController.isNewGame = " + PlayerController.isNewGame);
        if(PlayerController.isNewGame)
        {
            PlayerPrefs.SetInt("mathLevelComplete", 0);
            PlayerPrefs.SetInt("leverLevelComplete", 0);
            PlayerPrefs.SetInt("boulderLevelComplete", 0);
            Debug.Log("GameManager Start: Reset levelCompletes");
            Debug.Log("currently mathLevelComplete is" + PlayerPrefs.GetInt("mathLevelComplete"));
        }

        if(PlayerPrefs.GetInt("mathLevelComplete") == 1)
        {
            Destroy(mathChest);
            Destroy(mathNPC);
        }

        if(PlayerPrefs.GetInt("leverLevelComplete") == 1)
        {
            Destroy(leverChest);
        }

        if(PlayerPrefs.GetInt("boulderLevelComplete") == 1)
        {
            Destroy(boulderChest);
        }
    }


    void Update()
    {
        // Debug.Log("Update: currently mathLevelComplete is" + PlayerPrefs.GetInt("mathLevelComplete"));
    
    }
}
