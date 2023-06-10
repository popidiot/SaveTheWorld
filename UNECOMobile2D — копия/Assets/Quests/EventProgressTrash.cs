using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventProgressTrash : MonoBehaviour
{
    public Text EventText;
    public Text EventText2;
    public static int Progress;
    public static int trashProgress;
    void Start()
    {
        trashProgress = 0;
    }

    // Update is called once per frame
    private void Update()
    {
       
        EventText2.text = "Полян убрано: " + trashProgress;

    }
}
