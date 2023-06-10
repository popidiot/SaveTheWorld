using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinButton : MonoBehaviour
{
    public GameObject skinUI;
    public bool vkl;
    // Start is called before the first frame update
    void Start()
    {
        vkl = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void skinButton()
    {
        if (vkl == false)
        {
            skinUI.SetActive(false);
            vkl = true;
        }
        else 
        {
            skinUI.SetActive(true);
           vkl=false;
        }
    }
}
