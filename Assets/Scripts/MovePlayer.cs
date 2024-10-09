using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody2D playerRB;
    public float jumpForce = 5f;
    private bool onGround;
    public float moveSpeed = 5f;
    public GameObject retryButton;
    [SerializeField] Gameover deathMenu;

    // Start is called before the first frame update
    void Start()
    {
       playerRB = GetComponent<Rigidbody2D>();
        retryButton.SetActive(false);
     

    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        playerRB.velocity = new Vector2(move * moveSpeed, playerRB.velocity.y);
        if (Input.GetKeyDown(KeyCode.UpArrow)&& onGround)
        {
            playerRB.AddForce(Vector2.up*jumpForce,ForceMode2D.Impulse); 
            onGround = false;   
        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        onGround = true;
        if (collision.gameObject.CompareTag("kill"))
        {
            retryButton.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void Retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("kill"))
        {
            deathMenu.ActiveScreenLose();

        }
    }
}






