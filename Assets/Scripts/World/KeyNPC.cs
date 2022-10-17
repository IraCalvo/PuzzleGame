using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyNPC : MonoBehaviour
{
    
    public GameObject dialogLessThan3;
    public GameObject dialogWhenAllKeys;

    public void whenTalkedTo()
    {
        StartCoroutine(talkedTo());
    }

    IEnumerator talkedTo()
    {
        if(PlayerPrefs.HasKey("keyCount"))
        {
            if(PlayerPrefs.GetInt("keyCount") == 3)
            {
                dialogWhenAllKeys.SetActive(true);
                PlayerController.instance.PlayerCannotMove();
                yield return new WaitForSeconds(2.5f);
                SceneManager.LoadScene("Fin");
            }

            if(PlayerPrefs.GetInt("keyCount") != 3)
            {
                dialogLessThan3.SetActive(true);
                PlayerController.instance.PlayerCannotMove();
            }
        }

        yield return null;
    }
}
