using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private float score;

    public float pointsPSecond = 10f;

    private bool isGameActive = true;

    void Update()
    {
        if (isGameActive)
        {

            score += pointsPSecond * Time.deltaTime;

            scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();
        }
    }


    public void StopScoring()
    {
        isGameActive = false;
    }

}