using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialFloorTile : MonoBehaviour
{
    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if(otherCollider.tag == "Boulder")
        {
            wall1.gameObject.SetActive(false);
            wall2.gameObject.SetActive(false);
            wall3.gameObject.SetActive(true);
        }
        if(otherCollider.tag != "Boulder")
        {
            wall1.gameObject.SetActive(true);
            wall2.gameObject.SetActive(true);
            wall4.gameObject.SetActive(false);
        }
    }
}
