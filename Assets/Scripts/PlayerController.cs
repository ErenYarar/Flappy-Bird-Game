using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float velocity = 1f;
    public Rigidbody2D rb2D;

    public bool isDead;
    public GameObject DeathScreen;

    public GameManager managerGame;

    private void Start()
    {
        //rb2D = GetComponent<Rigidbody2D>(); 
        Time.timeScale = 1;
    }

    private void Update()
    {
        //Get Touch
        if (Input.GetMouseButtonDown(0))
        {
            //Flying
            rb2D.velocity = Vector2.up * velocity;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ScoreArea")
        {
            managerGame.UpdateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;

            DeathScreen.SetActive(true);
        }
    }

}
