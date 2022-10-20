using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaveEntrance : MonoBehaviour
{
    [SerializeField] string levelName;

    public void OnCaveEntry()
    {
        SceneManager.LoadScene(levelName);
    }


}
