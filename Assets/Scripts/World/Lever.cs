using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{

    public GameObject wall1;
    public GameObject wall2;
    public GameObject activatedLever;
    public GameObject deactivatedLever;



    public void OnLeverActivation()
    {
        Debug.Log("can you read this?");

        if(wall1.activeInHierarchy == true)
        {
            wall1.gameObject.SetActive(false);
        }
        else
        {
            wall1.gameObject.SetActive(true);
        }

        if(wall2.activeInHierarchy == false)
        {
            wall2.gameObject.SetActive(true);
        }
        else
        {
            wall2.gameObject.SetActive(false);
        }

        if(activatedLever.activeInHierarchy == false)
        {
            activatedLever.gameObject.SetActive(true);
            deactivatedLever.gameObject.SetActive(false);
        }
        else
        {
            activatedLever.gameObject.SetActive(false);
            deactivatedLever.gameObject.SetActive(true);
        }



    }
}
