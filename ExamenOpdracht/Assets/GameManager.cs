using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager GetInstance() { return instance; }



    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        int score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int extraScore)
    {
        score += extraScore;
    }

    public int Score
    {
        get { return score; }
    }
}
