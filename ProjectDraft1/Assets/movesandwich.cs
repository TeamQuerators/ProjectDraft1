﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movesandwich : MonoBehaviour
{
    public int occupiedSlot = 0;
    public string mousecontrolled = "n";
    // Start is called before the first frame update
    void Start()
    {
        occupiedSlot = gameplay.selectedSlot;
        Debug.Log (occupiedSlot);
    }

    // Update is called once per frame
    void Update()
    {
        if (mousecontrolled == "y")
        {
            Vector2 mousePosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;
        }

        if ((gameplay.deleteFood == "y") && mousecontrolled == "y")
        {
            Destroy(gameObject);
        }

    }

    void OnMouseDown()
    {
        mousecontrolled = "y";
        gameplay.selectedSandwich = occupiedSlot;

    }
}
