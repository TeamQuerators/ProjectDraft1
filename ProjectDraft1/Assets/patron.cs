using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patron : MonoBehaviour
{
    public string orderedMeat = "hamburger";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnMouseOver()
    {
        if ((gameplay.deleteFood == "y") && (gameplay.currentMeat == orderedMeat))
        {
            Destroy(gameObject);
            gameplay.deleteFood = "n"; 

        }
    }

    //
}
