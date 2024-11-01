using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NestedConditionals : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Kaden");

        //Nested conditionals are conditionals inside of conditionals
        //Change measurement and bloom so that:
        // 1) only "full grown flower prints
        // 2) "full grown flower" and "flower is ready to pick" both print
        // 3) only "flower is ready to pick" prints

        float measurement = 6.2f;
        string bloom = "Full";

        if (measurement > 5)
        {
            print("Full grown flower");
            if (bloom == "Full")
            {
                print("Flower is ready to pick");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
