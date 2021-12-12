using UnityEngine;
//Describes the Healthbar appearance
public class HealthBar : MonoBehaviour
{
    // Update is called once per frame
    // Used to update health bar hearts based on damage
    void Update()
    {
        if (PlayerMovement.health <= 1)
        {
            DestroyGameObject("OneHeart");
            FindObjectOfType<GameManger>().EndGame();
            PlayerMovement.health = 100;
        }
        else if (PlayerMovement.health <= 34)
        {
            DestroyGameObject("TwoHearts");
        }
        else if (PlayerMovement.health <= 67)
        {
            DestroyGameObject("Full");
        }

    }

    // Destroys the target when the Player hits it with an attack
    private void DestroyGameObject(string obj)
    {
        GameObject destoryObj = GameObject.Find(obj);
        Destroy(destoryObj);
    }
}
