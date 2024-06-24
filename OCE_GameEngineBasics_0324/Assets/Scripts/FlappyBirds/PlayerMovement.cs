using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;

    [SerializeField]
    private float jumpForce;

    private bool shouldJump;

    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    void Update()
    {
        GetUserInput();

        if (shouldJump)
        {
            Jump();
            shouldJump = false;
        }

        // TESTING PURPOSES
        if(Input.GetKeyDown(KeyCode.S))
        {
            scoreManager.SaveHighscore();
        }
    }

    void GetUserInput()
    {
        shouldJump = Input.GetKeyDown(KeyCode.Space);
    }

    void Jump()
    {
        rb.velocity = Vector2.zero;
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        Debug.Log("Jump!");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        scoreManager.AddScore();
    }

}
