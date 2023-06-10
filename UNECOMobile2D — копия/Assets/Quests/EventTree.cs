using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTree : MonoBehaviour
{

    void Start()
    {
        stop = true;
    }
    public bool stop;
    private EventTree eventTree;
    [Obsolete]
    void OnMouseDown()
    {
        if (GameObject.FindGameObjectWithTag("Quest").GetComponent<QuestEvent>().Quest3 == true)
        {
            Animation collect = GetComponent<Animation>();
            if (collect.Play("growth"))
            {
                Debug.Log("Onm");


                eventTree = GetComponent<EventTree>();
                eventTree.enabled = false;
                if (stop == true)
                {
                    EventProgressTree.TreeProgress++;
                }

                stop = false;
            }
        }

    }
}
