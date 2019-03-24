﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bincontrol : MonoBehaviour
{
    public Transform bottombunObj;
    public Transform topbunObj;
    public Transform burgerObj;
    public Transform backrollObj;
    public Transform frontrollObj;
    public Transform hotdogObj;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if (gameObject.name == "bun bin")
        {
            if (gameplay.cuttingboardS1 == "empty")
            {
                Instantiate(bottombunObj, new Vector2(-1, -.5f), bottombunObj.rotation);
                Instantiate(topbunObj, new Vector2(-1, -.4f), topbunObj.rotation);
                gameplay.cuttingboardS1 = "justbun";
                gameplay.selectedSlot = 1;
            }
            else
                 if (gameplay.cuttingboardS2 == "empty")
            {
                Instantiate(bottombunObj, new Vector2(0, -.5f), bottombunObj.rotation);
                Instantiate(topbunObj, new Vector2(0, -.4f), topbunObj.rotation);
                gameplay.cuttingboardS2 = "justbun";
                gameplay.selectedSlot = 2;
            }

            else
                 if (gameplay.cuttingboardS3 == "empty")
            {
                Instantiate(bottombunObj, new Vector2(1, -.5f), bottombunObj.rotation);
                Instantiate(topbunObj, new Vector2(1, -.4f), topbunObj.rotation);
                gameplay.cuttingboardS3 = "justbun";
                gameplay.selectedSlot = 3;
            }
        }

        if (gameObject.name == "hamburgers")
        {
            if (gameplay.grillS1 == "empty")
            {
                Instantiate(burgerObj, new Vector2(6, 0), burgerObj.rotation);
                gameplay.grillS1 = "full";
            }

            else
            if (gameplay.grillS2 == "empty")
            {
                Instantiate(burgerObj, new Vector2(7, 0), burgerObj.rotation);
                gameplay.grillS2 = "full";
            }

            else
            if (gameplay.grillS3 == "empty")
            {
                Instantiate(burgerObj, new Vector2(8, 0), burgerObj.rotation);
                gameplay.grillS3 = "full";
            }


        }

        if (gameObject.name == "hotdog bin")
        {
            if (gameplay.grillS1 == "empty")
            {
                Instantiate(hotdogObj, new Vector2(6, 0), hotdogObj.rotation);
                gameplay.grillS1 = "full";
            }

            else
            if (gameplay.grillS2 == "empty")
            {
                Instantiate(hotdogObj, new Vector2(7, 0), hotdogObj.rotation);
                gameplay.grillS2 = "full";
            }

            else
            if (gameplay.grillS3 == "empty")
            {
                Instantiate(hotdogObj, new Vector2(8, 0), hotdogObj .rotation);
                gameplay.grillS3 = "full";
            }


        }

    }
}
    