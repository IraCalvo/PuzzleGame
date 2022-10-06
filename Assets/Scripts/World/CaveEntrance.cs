using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaveEntrance : MonoBehaviour
{
    public Object scene;

    public void OnCaveEntry()
    {
        SceneManager.LoadScene(scene.name);
    }


}
