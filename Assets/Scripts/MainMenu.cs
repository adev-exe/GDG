using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

// Main menu options and buttons
public class MainMenu : MonoBehaviour
{
    
    // Resets target amount and loads scene
    public void PlayGame()
    {
       PlayerMovement.targetAmount = 8;
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // Quits out of the game when the Player presses the 'esc' key
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}