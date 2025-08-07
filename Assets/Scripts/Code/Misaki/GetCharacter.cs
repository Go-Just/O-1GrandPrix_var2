using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;
using TMPro;

public class GetCharacter : MonoBehaviour
{
    public GameData gamedata;
    public TextMeshProUGUI Character;
    void Start()
    {

    }


    void Update()
    {

        if (gamedata.CharactersList[gamedata.IndexCounter].isGet == false)
        {
            gamedata.IndexCounter = (gamedata.IndexCounter + 1) % gamedata.CharactersList.Count;
        }
        else
        {
            GetCharactertrue();
        }


    }
    void GetCharactertrue()
    {
         if (gamedata.CharactersList[gamedata.IndexCounter].isGet == true)
        {
            Character.text = gamedata.CharactersList[gamedata.IndexCounter].Charactername;

        }
    
    }    
}
