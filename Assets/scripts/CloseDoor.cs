using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    public GameObject Collerdoor1;
    public GameObject Collerdoor2;
    public GameObject lever_open;
    public GameObject lever_dicht;



    public void OnMouseDown()
    {
        Collerdoor1.SetActive(true);
        Collerdoor2.SetActive(false);
        lever_open.SetActive(true);
        lever_dicht.SetActive(false);
    }
}
