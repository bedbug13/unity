using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comparison : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Kaden");
        int a = 3;
        int b = 6;
        print(a < b);

        int c = 11;
        int d = 5;
        print(c >= 8 && d != 4);

        int x = 5;
        int y = 26;
        print(x == 7 || y <= 24);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
