using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Kaden");
        int score = 70;
        if (score > 100)
        {
            print("You Won!");
        }
        else if (score > 70)
        {
            print("You're getting close!");
        }
        else if (score > 40)
        {
            print("Real Progress");
        }
        else if (score >= 0)
        {
            print("Keep Trying!");
        }
        else
        {
            print("You lost, try again.");
        }
        whatToWear(85);
        whatToWear(75);
        whatToWear(65);
        whatToWear(30);
        winnerchicken(50, 20);
        winnerchicken(10, 70);
        winnerchicken(25, 25);

        GreaterThanOrEqualTo(25, 200); // should print false since 25 is not greather than or equal to 200
        IsEven(4); // should print true since 4 is even
        GetLetterGrade(91); // should print a
        GetLetterGrade(75); // should print c


    }
    void whatToWear(int temp2)
    {
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
    }
    //Write a function that determines if Team A won, Team B won, or it was a tie. Then call it in the start method
    // using different values such that team a wins, team b wins, and they tie

    void winnerchicken(int scoreA, int scoreB)
    {
        if (scoreA == scoreB)
        {
            print("Team Tied!");
        }
        else if (scoreA > scoreB)
        {
            print("TeamA Won");
        }
        else
        {
            print("Team B won!");
        }
    }
    void GreaterThanOrEqualTo(int numOne, int numTwo)
    {
        // Use a conditional structure to print whether numOne is greater than or equal to numTwo.
        if (numOne >= numTwo)
        {
            print("true");
        }
        else
        {
            print("False");
        }
        
    }

    void IsEven(int num)
    {
        // Use conditionals to print whether num is even or odd (Hint: use % modulo operator)
        if (num % 2 == 0)
        {
            print("True");
        }
        else
        {
            print("false");
        }
    }

    void GetLetterGrade(float percentage)
    {
        // Use conditionals to print the equivalent letter grade of the given percentage.
        if (percentage >= 90)
        {
            print("A");
        }
        else if (percentage >= 80)
        {
            print("B");
        }
        else if (percentage >= 70)
        {
            print("C");
        }
        else
        {
            print("D");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
