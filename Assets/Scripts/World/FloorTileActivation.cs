using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTileActivation : MonoBehaviour
{
    public GameObject wall;



    public void OnTriggerStay2D(Collider2D otherCollider)
    {

        if(otherCollider.tag != "Boulder")
        {
            wall.gameObject.SetActive(true);
        }
        if(otherCollider.tag == "Boulder")
        {
            wall.gameObject.SetActive(false);
        }
        
    }
}
