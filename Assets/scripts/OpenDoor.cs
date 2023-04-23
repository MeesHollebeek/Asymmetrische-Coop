using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject Collerdoor1;
    public GameObject Collerdoor2;
    public GameObject lever_open;
    public GameObject lever_dicht;



   public void OnMouseDown()
    {
        Collerdoor1.SetActive(false);
        Collerdoor2.SetActive(true);
        lever_open.SetActive(false);
        lever_dicht.SetActive(true);
    }
}

