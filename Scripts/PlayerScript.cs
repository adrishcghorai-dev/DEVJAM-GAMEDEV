using System.Collections;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // COMPONENTS
    private Rigidbody2D rb;
    public Animator animator;
    private AudioSource audiosource;
    private SpriteRenderer SR;

    // MOVEMENT
    public float runSpeed = 6f;
    public float jump = 12f;
    public float downforce = 2f;

    // WALL JUMP
    public float wallJumpXForce = 8f;
    public float wallJumpYForce = 12f;
    public float wallJumpDelay = 0.2f;

    // STATE
    private bool isGrounded;
    private bool Touchingwall;
    private bool isWallJumping;

    // AUDIO
    public AudioClip jumpClip;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audiosource = GetComponent<AudioSource>();
        SR = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float moveinput = Input.GetAxis("Horizontal");

        // Horizontal Movement
        if ((isGrounded || !Touchingwall) && !isWallJumping)
        {
            rb.linearVelocity = new Vector2(moveinput * runSpeed, rb.linearVelocity.y);
        }

        // Jump Input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, jump);
            }
            else if (Touchingwall && !isWallJumping)
            {
                if (Input.GetKey(KeyCode.A))
                    StartCoroutine(WallJump(-1));
                else if (Input.GetKey(KeyCode.D))
                    StartCoroutine(WallJump(1));
            }
        }

        // Wall Slide
        if (Touchingwall && !isGrounded && !isWallJumping)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, -downforce);
        }

        // Sprite Flip
        if (rb.linearVelocity.x != 0 && !Touchingwall)
        {
            SR.flipX = rb.linearVelocity.x < 0;
        }

        Animation(moveinput);
    }

    IEnumerator WallJump(int direction)
    {
        isWallJumping = true;

        // Brief wall slide pause
        rb.linearVelocity = new Vector2(0, -downforce);
        yield return new WaitForSeconds(wallJumpDelay);

        // Apply delayed vertical jump
        rb.linearVelocity = new Vector2(direction * wallJumpXForce, wallJumpYForce);

        yield return new WaitForSeconds(0.1f);
        isWallJumping = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") ||
            collision.gameObject.CompareTag("player 1") ||
            collision.gameObject.CompareTag("player 2"))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag("GameController"))
        {
            Touchingwall = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }

        if (collision.gameObject.CompareTag("GameController"))
        {
            Touchingwall = false;
        }
    }

    void Animation(float moveinput)
    {
        if (isGrounded)
        {
            if (moveinput == 0)
            {
                animator.Play("virtual guy idle Animation");
                animator.Play("pink man idle Animation");
            }
            else
            {
                animator.Play("virtual guy run Animation");
                animator.Play("pink man run Animation");
            }
        }
        else if (Touchingwall)
        {
            animator.Play("virtual guy wall jump Animation");
            animator.Play("pink man wall jump Animation");
        }
        else
        {
            if (rb.linearVelocity.y > 0)
            {
                animator.Play("virtual guy jump Animation");
                animator.Play("pink man jump Animation");
            }
            else
            {
                animator.Play("virtual guy fall Animation");
                animator.Play("pink man fall Animation");
            }
        }
    }

    private void PlaySfx(AudioClip audioclip)
    {
        audiosource.clip = audioclip;
        audiosource.Play();
    }
}
