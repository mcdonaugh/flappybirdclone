using Unity.VisualScripting;
using UnityEngine;

public class GameStateController : MonoBehaviour
{

    public void Start ()
    {
        //Generates the start screen
        ViewStartScreen();
    }
    
    public void ViewStartScreen()
    {
        //Generates Start Screen
        Debug.Log($"This");
    }
    public void ViewScoreScreen()
    {
        //Opens Score Screen
        Debug.Log($"You are viewing the score");

        // If Close Button is pressed, return to previous screen
        CloseScreen();
    }
    
    public void StartGame()
    {
        //Whene Start Is Pressed, Start Game
        Debug.Log($"The Game Has Started!");
    }

    public void ViewGameOverScreen()
    {
        //if button is pressed, can 
    }

    public void EndGame()
    {
        //Resets the game back to StartGame
        AssignMedal();
        ViewStartScreen();
    }

    public void CloseScreen()
    {
        //Closes overlay screens and returns to previous screen
    }

    public void AssignMedal()
    {
        //Assigns a medal to the game over screen
        //10 - Bronze
        //20 - Silver
        //30 - Gold
        //40 - Plat
    }
}