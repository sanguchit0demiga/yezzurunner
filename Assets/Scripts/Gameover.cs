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
    public Score highScore;
    [SerializeField] GameObject Win;
    [SerializeField] GameObject Lose;
    void Start()
    {
        Win.SetActive(false);
        Lose.SetActive(false);
    }
    public void ActiveScreenLose()
        { 
        Lose.SetActive(true);
        Time.timeScale = 0f;
            }

  
    public void Restart ()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}