using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D rd2d;
    private int count;
    private int lives;
    public float speed;

    public Text countText;
    public Text winText;
    public Text livesText;

    Animator anim;
    private bool facingRight;
    private int moveHorizontal;

    public AudioClip musicClipOne;
    public AudioClip musicClipTwo;
    public AudioClip musicClipThree;
    public AudioClip musicClipFour;
    public AudioClip musicClipFive;
    public AudioSource musicSource;

    void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();

        count = 0;

        lives = 3;

        SetCountText();

        SetlivesText();

        winText.text = "";

        anim = GetComponent<Animator>();

        facingRight = true;

        moveHorizontal = 0;

    }

    void FixedUpdate()
    {
        float hozMovement = Input.GetAxis("Horizontal");

        float vertMovement = Input.GetAxis("Vertical");

        rd2d.AddForce(new Vector2(hozMovement * speed, vertMovement * speed));

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Coin")
        {
            Destroy(collision.collider.gameObject);

            count = count + 1;

            SetCountText();

            musicSource.clip = musicClipOne;

            musicSource.Play();

        }
        else if (collision.collider.tag == "Enemy")
        {
            Destroy(collision.collider.gameObject);

            lives = lives - 1;

            SetCountText();

            SetlivesText();

            musicSource.clip = musicClipTwo;

            musicSource.Play();

        }
        if (collision.collider.tag == "Life")
        {
        Destroy(collision.collider.gameObject);

        lives = lives + 1;

        SetCountText();

        SetlivesText();

        musicSource.clip = musicClipThree;

        musicSource.Play();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if (count == 4)
        {
            transform.position = new Vector2(50.0f, 50.0f);
        }
        if (count >= 7)
        {
            winText.text = "You win! Game created by Byron Bess!";

            musicSource.clip = musicClipFour;

            musicSource.Play();
        }
    }



    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {

            if (Input.GetKey(KeyCode.UpArrow))
            {
                rd2d.AddForce(new Vector2(0, 3), ForceMode2D.Impulse);

                anim.SetInteger("State", 2);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                anim.SetInteger("State", 1);
            }

            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                anim.SetInteger("State", 0);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                anim.SetInteger("State", 1);
            }

            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                anim.SetInteger("State", 0);
            }

        }
    }
    private void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        if (facingRight == false && moveHorizontal > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveHorizontal < 0)
        {
            Flip();
        }

    }
    void SetlivesText()
    {
        livesText.text = "Lives: " + lives.ToString();
        if (lives == 0)
        {
            Destroy(gameObject);

            winText.text = "You Lose!";

            musicSource.clip = musicClipFive;

            musicSource.Play();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;

        Vector2 Scaler = transform.localScale;

        Scaler.x = Scaler.x * -1;

        transform.localScale = Scaler;

    }
}

