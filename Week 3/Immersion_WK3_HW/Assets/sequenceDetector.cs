using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sequenceDetector : MonoBehaviour
{
    public GameObject ObjectToEnable;


    //write the order in which you want to detect your triggers.
    //NAMES MUST BE EXACT MATCH for the name of the GameObject with the Trigger
    //pattern will automatically loop
    public List<string> pattern = new List<string> { "Zone2", "Zone1" };

    private int pcounter;
    private bool gotPattern;

    // Start is called before the first frame update
    void Start()
    {
        pcounter = 0;
        gotPattern = false;
        if (ObjectToEnable != null) ObjectToEnable.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == pattern[pcounter])
        {
            Debug.Log("following pattern: " + other.name);
            pcounter++;
            if (pcounter >= pattern.Count)
            {//got to the end of the pattern!
                if (ObjectToEnable != null) ObjectToEnable.SetActive(true);
                gotPattern = true;
                pcounter = 0;
            }
        }
        else
        {
            Debug.Log("lost pattern: got " + other.name + ", looking for " + pattern[pcounter]);
            if (ObjectToEnable != null) ObjectToEnable.SetActive(false);
            gotPattern = false;
            pcounter = 0;
        }
    }


}


