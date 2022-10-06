using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour
{

    [SerializeField] private GameObject boulder;
    [SerializeField] private GameObject originalSpot;

    public void OnResetButton()
    {
        //transform.position.gameObject.boulder = transform.position.originalSpot;
    }
}
