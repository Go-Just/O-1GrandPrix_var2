using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Manager : MonoBehaviour
{
    private int Counter;
    public  GameData gameData;
    public void OnClick()
    {
        Counter++;
        Debug.Log($"Counter = {Counter}");
    }

    //6.11日(3のコード
    public void OnClickRight()
    {
        if(gameData.IndexCounter == gameData.CharactersList.Count - 1)
        {
            gameData.IndexCounter = 0;
        }
        else
        {
            gameData.IndexCounter++;
        }
    }

    public void OnClickLeft()
    {
        if(gameData.IndexCounter == 0)
        {
            gameData.IndexCounter = gameData.CharactersList.Count - 1;
        }
        else
        {
            gameData.IndexCounter--;
        }
    }
    //6.11日(3ここまで
}
