using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Gameover : MonoBehaviour
{
    // Start is called before the first frame update
    public Text puntajeFinalText;
    
    
    [SerializeField] GameObject Lose;
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject retryButton;
    void Start()
    {
        gameOver.SetActive(false);
        retryButton.SetActive(false);
    }
    public void ActiveScreenLose()
        {
        gameOver.SetActive(true);
       
        retryButton.SetActive(true);
        Lose.SetActive(true);
        Time.timeScale = 0f;
            }

  
    public void Restart ()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}