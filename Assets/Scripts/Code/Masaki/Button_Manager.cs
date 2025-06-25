using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Manager : MonoBehaviour
{
    private int Counter;
    public GameData gameData;
    public void OnClick()
    {
        Counter++;
        Debug.Log($"Counter = {Counter}");
    }

    //6.11日(3のコード
    public void OnClickRight()
    {
        if (gameData.IndexCounter == gameData.CharactersList.Count - 1)
        {
            gameData.IndexCounter = 0;
        }
        else
        {
            gameData.IndexCounter++;
        }
        Debug.Log($"押された\nIndexCounter = {gameData.IndexCounter}");
    }

    public void OnClickLeft()
    {
        if (gameData.IndexCounter == 0)
        {
            gameData.IndexCounter = gameData.CharactersList.Count - 1;
        }
        else
        {
            gameData.IndexCounter--;
        }
        Debug.Log($"押された\nIndexCounter = {gameData.IndexCounter}");
    }
    //6.11日(3ここまで
    //6.19Character.isGetがTrueであれば表示できる。について
    public void OnClickRight_ver2()
    {
        while (true)
        {
            NextIndex(gameData.CharactersList.Count - 1, 0, +1);
            if (gameData.CharactersList[gameData.IndexCounter].isGet)
            {
                break;
            }
        }
    }

    public void OnClickLeft_ver2()
    {
        while (true)
        {
            NextIndex(0, gameData.CharactersList.Count - 1, -1);
            if (gameData.CharactersList[gameData.IndexCounter].isGet)
            {
                break;
            }
        }
    }

    public void NextIndex(int BorderNum, int BorderNextNum,int SumNum)
    {
        if (gameData.IndexCounter == BorderNum)
        {
            gameData.IndexCounter = BorderNextNum;
        }
        else
        {
            gameData.IndexCounter += SumNum;
        }
    }

    //6.19Character.isGetがTrueであれば表示できる。ここまで(Script自体はIndicationCharacterStatusで問題ないはず？)
}
