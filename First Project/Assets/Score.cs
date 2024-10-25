using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score = 0;

    // Start is called before the first frame update
    public void AddScore()
    {
        score++;
        print(score);
    }

}
