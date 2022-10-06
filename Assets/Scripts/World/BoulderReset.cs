using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderReset : MonoBehaviour
{
    public GameObject originalPosition;
    public GameObject originalPosition2;
    public GameObject originalPosition3;
    public GameObject originalPosition4;
    public GameObject originalPosition5;
    public GameObject originalPosition6;
    public GameObject originalPosition7;
    public GameObject originalPosition8;
    public GameObject Boulder;
    public GameObject Boulder2;
    public GameObject Boulder3;
    public GameObject Boulder4;
    public GameObject Boulder5;
    public GameObject Boulder6;
    public GameObject Boulder7;
    public GameObject Boulder8;

    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;
    public GameObject wall5;
    public GameObject wall6;
    public GameObject wall7;
    public GameObject wall8;
    public GameObject wall9;
    public GameObject wall10;

    public void OnLeverActivation()
    {
        Boulder.transform.position = originalPosition.transform.position;
        Boulder2.transform.position = originalPosition2.transform.position;
        Boulder3.transform.position = originalPosition3.transform.position;
        Boulder4.transform.position = originalPosition4.transform.position;
        Boulder5.transform.position = originalPosition5.transform.position;
        Boulder6.transform.position = originalPosition6.transform.position;
        Boulder7.transform.position = originalPosition7.transform.position;
        Boulder8.transform.position = originalPosition8.transform.position;

        if(wall1.activeInHierarchy == false)
        {
            wall1.gameObject.SetActive(true);
        }
        if(wall2.activeInHierarchy == false)
        {
            wall2.gameObject.SetActive(true);
        }
        if(wall3.activeInHierarchy == false)
        {
            wall3.gameObject.SetActive(true);
        }
        if(wall4.activeInHierarchy == false)
        {
            wall4.gameObject.SetActive(true);
        }
        if(wall5.activeInHierarchy == false)
        {
            wall5.gameObject.SetActive(true);
        }
        if(wall6.activeInHierarchy == false)
        {
            wall6.gameObject.SetActive(true);
        }
        if(wall7.activeInHierarchy == false)
        {
            wall7.gameObject.SetActive(true);
        }
        if(wall8.activeInHierarchy == false)
        {
            wall8.gameObject.SetActive(true);
        }
        if(wall9.activeInHierarchy == false)
        {
            wall9.gameObject.SetActive(true);
        }
        if(wall10.activeInHierarchy == false)
        {
            wall10.gameObject.SetActive(true);
        }

    }
}
