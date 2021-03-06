﻿using UnityEngine;
using System.Collections;

public class BackgroundSceneComponent : MonoBehaviour
{

    public bool isBack = false;
    public bool isRight = false;
    public bool isLeft = false;
    Color maincolor;
    Color onMouseEntercolor;
    Color onMouseClickColor;
    static public int index = 0;

    public GameObject[] FemaleHairs = new GameObject[5];
    public GameObject[] MaleHairs = new GameObject[4];
    void Start()
    {
        //Assign the Color
        maincolor = new Color(0f, 0f, 0f, 1f);
        onMouseEntercolor = new Color(0.9607f, 0.6784f, 0.3450f, 1f);
        onMouseClickColor = new Color(0.2f, 0.1882f, 0.1921f, 1f);
        GetComponent<Renderer>().material.color = maincolor;
        //Assign the Arrays Objects
        FemaleHairs[0] = GameObject.FindGameObjectWithTag("FemaleHair1");
        FemaleHairs[1] = GameObject.FindGameObjectWithTag("FemaleHair2");
        FemaleHairs[2] = GameObject.FindGameObjectWithTag("FemaleHair3");
        FemaleHairs[3] = GameObject.FindGameObjectWithTag("FemaleHair4");
        FemaleHairs[4] = GameObject.FindGameObjectWithTag("FemaleHair5");

        MaleHairs[0] = GameObject.FindGameObjectWithTag("MaleHair1");
        MaleHairs[1] = GameObject.FindGameObjectWithTag("MaleHair2");
        MaleHairs[2] = GameObject.FindGameObjectWithTag("MaleHair3");
        MaleHairs[3] = GameObject.FindGameObjectWithTag("MaleHair4");

        if (StartSceneButton.activeF)
            ActiveFemale();


        if (StartSceneButton.activeM)
            ActiveMale();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseEnter()
    {
        //Color of the Buttons on Mouse Enter
        GetComponent<Renderer>().material.color = onMouseEntercolor;
    }

    void OnMouseExit()
    {
        //Color of the buttons on Mouse Exit return to main color

        GetComponent<Renderer>().material.color = maincolor;
    }
    void OnMouseUp()
    {
        //Color of the buttons on Mouse Up
        GetComponent<Renderer>().material.color = onMouseClickColor;
        //If Click Back go in the last scene
        if (isBack)
        {
            Application.LoadLevel("SceneTryToYourself");
        }
        //Right and Left Change the index value
        if (isRight)
        {
            if (index < 7)
                index++;
            else
                index = 0;

            print(index);
        }
        if (isLeft)
        {
            if (index > 0)
                index--;
            else
                index = 7;
            print(index);
        }
    }
    //ActiveFemale and ActiveMale active the script in the haircut selected
    void ActiveFemale()
    {
        FemaleHairs[SelectHairForYryScene.indexTOT].GetComponent<ModelHatController>().enabled = true;
    }

    void ActiveMale()
    {
        MaleHairs[SelectHairForYryScene.indexTOT].GetComponent<ModelHatController>().enabled = true;

    }
}
