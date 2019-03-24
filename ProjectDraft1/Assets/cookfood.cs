﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookfood : MonoBehaviour
{

    public float cookingTime = 0;
    public int occupiedSlot = 100;
    public string mousecontrolled = "n";
    public string toppingStatus;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(occupiedSlot + "   " + gameplay.selectedSlot);

        if (occupiedSlot == gameplay.selectedSandwich)
        {
            mousecontrolled = "y";
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = new Vector2(objPosition.x, objPosition.y - .2f);
            if (gameObject.name == "burger patty(Clone)")
            {
                gameplay.currentMeat = "hamburger";
            
            }


        }


        if ((gameplay.deleteFood == "y") && mousecontrolled == "y")
        {
            Destroy(gameObject);
        }

        cookingTime += Time.deltaTime;
        if ((cookingTime > 5 && cookingTime < 10) && (transform.position.x >5))

        {
            GetComponent<SpriteRenderer> ().color = new Color(1, 1, 0);
        }

        if ((cookingTime > 10) && (transform.position.x > 5))
        {
            GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
        }

     
       

       




    }

    void OnMouseDown()
    {
        if (transform.position.x == 6)
        {
            gameplay.grillS1 = "empty";

        }

        if (transform.position.x == 7)
        {
            gameplay.grillS2 = "empty";

        }

        if (transform.position.x == 8)
        {
            gameplay.grillS3 = "empty";

        }



        if ((gameplay.cuttingboardS1 == "justbun") && (toppingStatus != "placed"))
        {
            GetComponent<Transform>().position = new Vector2(-1, -.6f);
            gameplay.cuttingboardS1 = "fullbun";
            occupiedSlot = 1;
            toppingStatus = "placed";
        }
        else
            if ((gameplay.cuttingboardS2 == "justbun") && (toppingStatus != "placed"))
            {
                GetComponent<Transform>().position = new Vector2(0, -.6f);
                gameplay.cuttingboardS2 = "fullbun";
                occupiedSlot = 2;
                toppingStatus = "placed";
            }

        else
            if ((gameplay.cuttingboardS3 == "justbun") && (toppingStatus != "placed"))
            {
                GetComponent<Transform>().position = new Vector2(1, -.6f);
                gameplay.cuttingboardS3 = "fullbun";
                occupiedSlot = 3;
                toppingStatus = "placed";
            }

    }
}
