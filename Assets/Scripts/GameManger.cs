using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//handles diffrent conditions for game end.
public class GameManger : MonoBehaviour
{

   bool gameEnded = false;
   //loss menu
   public void EndGame() {

        if (gameEnded == false)
        {
            gameEnded = true; 
            Debug.Log("GAME OVER");
            Restart("Retry");
        }
    }

    //Victory menu
    public void WonGame() 
    {
       
         Debug.Log("WINNER WINNER CHICKEN DINNER");
         Restart("Continue");
       
    }
    //handles reseting for next attempt
    public void Restart(string scene) 
    {
        gameEnded = false;
        SceneManager.LoadScene(scene);
       
    }


}
