﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameplay : MonoBehaviour
{
    public static string cuttingboardS1 = "empty";
    public static string cuttingboardS2 = "empty";
    public static string cuttingboardS3 = "empty";

    public static string grillS1 = "empty";
    public static string grillS2 = "empty";
    public static string grillS3 = "empty";

    public static int selectedSlot = 0;
    public static int selectedSandwich = 0;

    public KeyCode giveFood;

    public static string deleteFood = "n";
    public static string currentMeat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(giveFood))
        {
            deleteFood = "y";
        }
    }
}
