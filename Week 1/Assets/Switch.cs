using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{

    public GameObject ObjectToEnable;
    public GameObject ObjectToEnable2;


    void Start()
    {
        ObjectToEnable.SetActive(false);
        ObjectToEnable2.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
        ObjectToEnable.SetActive(true);
        ObjectToEnable2.SetActive(false);

    }

    void OnTriggerExit(Collider other)
    {
        ObjectToEnable.SetActive(false);
        ObjectToEnable2.SetActive(true);

    }


}

