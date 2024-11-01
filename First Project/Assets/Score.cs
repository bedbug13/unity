using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score = 0;
    public float timer = 10f;

    // Addscore increments the value of score by 1.
    public void AddScore()
    {
        if (timer > 0f)
        {
            score++;
            print("Score: " + score);
        }
        else
        {
            print("Out of time!");
        }
    }

    // Start is called before the first frame update
    void Update()
    {
        timer -= Time.deltaTime;
    }
    

}
