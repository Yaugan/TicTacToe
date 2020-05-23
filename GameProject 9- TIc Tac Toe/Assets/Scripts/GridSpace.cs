using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSpace : MonoBehaviour
{
    public Button button;
    public Text textButton;
    

    private GameController gameController;


    public void SetSpace()
    {
        if(gameController.playerMove == true)
        {
            textButton.text = gameController.GetPlayerSide();
            button.interactable = false;
            gameController.EndTurn();
        }        
    }

    public void SetGameControllerReference(GameController controller)
    {
        gameController = controller;
    }

}
