using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rewards : MonoBehaviour
{
    public int reward;
    // Start is called before the first frame update
    void Start()
    {
        Value.value = Value.value + reward;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
