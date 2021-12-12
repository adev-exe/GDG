using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//controlls the retry buttons functions after death and reseting 
public class Retry : MonoBehaviour
{

    public void PlayGame()
    {
        PlayerMovement.targetAmount = 8; // resets target amount
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); // loads scene
    }
    // Quits when the quit menu button is pressed
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }


}