using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Kaden");

        //Conditional statements are one way programs "Think" or make decisions

        bool condition = true;
        if (condition)
        {
            print("Do This Code");
        }

        //Choose a value for score that will make the print statement true
        int score = 758;
        if (score>50)
        {
            print("You won!");
        }

        //Write and if statement that will determine if a number is even.
        int num = 8;
        if ( num % 2 == 0)
        {
            print("The number is even");
        }

        //Else Statements - if the first condition doesn't work out, we still might want to do something

        //Write and if - statement that prints when a number is even or odd
        int num2 = 7;
        if ( num2 % 2 == 0)
        {
            print("The number is even");
        }
        else
        {
            print("The number is odd");
        }

        //make an if- else statement that tells you whether or not the water is boiling based on temperature. Water boils at 100 degrees celsius
        int temp = 42;
        if (temp >= 100)
        {
            print("The water is boiling");
        }
        else
        {
            print("The water is not boiling"); 
        }

        //Many times there are many situations we want to check - use else - if statements!

        //Write and else -if statement that prints 1) "It's hot outside. Wear shorts" if it's above 80 degrees
        //2) "It's warm outside. No jacket needed" if the temp is above 70 degrees
        //3) "It's getting chilly. Wear a jacket" if the temp is above 60 degrees
        //Otherwise it should print "It's cold outside. Wear a heavy jacket" 

        int temp2 = 72;
        if (temp2 >= 80)
        {
            print("It's hot outside. Wear shorts");
        }
        else if (temp2 > 70)
        {
            print("It's warm outside. No jacket needed");
        }
        else if (temp2 > 60)
        {
            print("It's getting chilly. Wear a jacket");
        }
        else
        {
            print("It's cold outside. Wear a heavy jacket");
        }

        //it works for boolean operators too!
        int temp3 = 85;
        string weather = "Sunny";
        if (temp3 < 70 || weather == "Rainy")
        {
            print("Wear a jacket");
        }
        else if (temp3 >80 && weather == "Sunny")
        {
            print("Put on sunblock");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
