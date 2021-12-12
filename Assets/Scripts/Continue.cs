using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Menu that displays on game victory
//allows Player to Restart game
public class Continue : MonoBehaviour
{
    //returns to original menu to restart game
    public void SendMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    //exits game
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}