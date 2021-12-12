using UnityEngine;
// This class controlls interactions with the gem targets
// and describes thier movement and controlls game win condition

public class TargetInteractions : MonoBehaviour
{
    [SerializeField] private float speed;

    private bool hit = false;
    private Animator anim;
    private Rigidbody2D body;

 
    private void Awake()
    {
        // Gets components from the game objects
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    private void Update()
    {
        body.velocity = new Vector2(0, Mathf.Sin(Time.time * speed) / 2);

        if (hit)
        {
            body.velocity = new Vector2(0, 0);
            anim.SetBool("Break", hit);
            // Animates the breaking of targets and stops the player from moving when attacking 

        }

        if(PlayerMovement.targetAmount == 0)
        {
            FindObjectOfType<GameManger>().WonGame();
            PlayerMovement.health = 100;
            // Puts the player into the the winning screen when the target counter reaches zero 
            // and fully restores the players health as to not die while winning.
        }
    }

    // Is called when the PlayerAttack detects a target in range and 
    // destroys the detected target, also reduces the count of remaining targets
    public void IsHit()
    {
        if (hit == false)
        {
            PlayerMovement.targetAmount--;
            hit = true;
        }
    }

}
