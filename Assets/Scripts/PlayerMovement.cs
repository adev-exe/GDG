using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float height;

    public static Animator anim;
    private Rigidbody2D body;
    private Animation target;
    private bool grounded;
    private bool left;
    public static bool attack;

    public static double health = 100;
    public static double damage = 33.4;

    public static int targetAmount = 8;

    private void Awake()
    {
        // Gets components from the game objects
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
       // target =  .GetComponent<Animation>();
    }

    private void Update()
    {
        attack = false;
        // Sets player speed and gathers the horizontal input
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        // Flips player left and right
        if (horizontalInput > -0.00f)
            left = false;

        else if (horizontalInput < -0.00f)
            left = true;
        //jump key press
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
            Jump();
      

     // Exit the application if the user presses the "escape" key

       // Does not work when playing from inside the Unity editor
   
       if (Input.GetKey("escape"))

       {

        Application.Quit();

       }

        // Set animator parameters
        anim.SetBool("Running", horizontalInput != 0);
        anim.SetBool("Grounded", grounded);
        anim.SetBool("Left", left);
    }

    
    //controls jump height and float
    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, height);
        anim.SetTrigger("Jump");
        grounded = false;
    }

    //handles block collisons
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Target")
        {
            grounded = true;
        }

        if (collision.gameObject.tag == "Spike")
        {
            takeDamage();
        }

      
    }

    //deals dmg to player
    public void takeDamage() {
        health = health - damage;
    }

};
