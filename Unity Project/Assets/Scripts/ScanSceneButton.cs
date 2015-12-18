﻿using UnityEngine;
using System.Collections;

public class ScanSceneButton : MonoBehaviour
{

    public bool isScan = false;
    public bool isBack = false;
    public bool isContinue = false;
    public bool isTryAgain = false;
    public static bool scan;
    public static bool tryagain;
    Color maincolor;
    Color onMouseEntercolor;
    Color onMouseClickColor;
    public Sprite ScanSprite;
    public Sprite TryAgainSprite;
    SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start()
    {
        maincolor = new Color(0f, 0f, 0f, 1f);
        onMouseEntercolor = new Color(0.9607f, 0.6784f, 0.3450f, 1f);
        onMouseClickColor = new Color(0.2f, 0.1882f, 0.1921f, 1f);
        GetComponent<Renderer>().material.color = maincolor;
        scan = false;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = onMouseEntercolor;
    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = maincolor;
    }
    void OnMouseUp()
    {
        GetComponent<Renderer>().material.color = onMouseClickColor;

        if (isScan)
        {
            ChangeTheDamnSprite();
            scan = true;        

        }
        if (isBack)
            CameraPosition.posCamera = 1;
        
        if (isContinue)
            CameraPosition.posCamera = 4;

        if (isTryAgain)
            tryagain = true;
          
    }

    //Change The Scan/Try Again Sprite Dinamically
    void ChangeTheDamnSprite()
    {    
        if(spriteRenderer.sprite == TryAgainSprite)
        {
            spriteRenderer.sprite = ScanSprite;
        }
                
        else if (spriteRenderer.sprite == ScanSprite) 
        {
            spriteRenderer.sprite = TryAgainSprite;
        }
        else
        {
            spriteRenderer.sprite = ScanSprite; 
        }
    }
}