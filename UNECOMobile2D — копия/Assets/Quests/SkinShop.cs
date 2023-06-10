using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;
using UnityEngine.UI;

public class SkinShop : MonoBehaviour
{
    public SpriteRenderer playersprite;
    public SpriteRenderer Spriteskin;
    // Start is called before the first frame update
    void Start()
    {
        //playersprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
       // playersprite.sprite = Spriteskin.sprite;
    }
    public void Buttonclicked()
        
    {
        Spriteskin = GetComponent<SpriteRenderer>();
        playersprite = GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>();
        playersprite.sprite = Spriteskin.sprite;
        Debug.Log("start");
    }
}
