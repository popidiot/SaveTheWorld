using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Value : MonoBehaviour
{
    public static int value;
    public Text text1;
    
    // Start is called before the first frame update
    void Start()
    {
        value = 0; 
        
    }

    // Update is called once per frame
    void Update()
    {
        text1.text = "Value: " + value;
        
    }
}
