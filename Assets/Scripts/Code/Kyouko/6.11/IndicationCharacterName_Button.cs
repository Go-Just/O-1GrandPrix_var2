using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IndicationCharacterName_Button : MonoBehaviour
{
    public GameData gameData;
    public TextMeshProUGUI NameSpaceText;
    void Start()
    {
        gameData.IndexCounter = 0;
        indicationCharacterName(gameData.CharactersList[gameData.IndexCounter]);
    }

    // Update is called once per frame
    void Update()
    {
        indicationCharacterName(gameData.CharactersList[gameData.IndexCounter]);
    }
    
    private void indicationCharacterName(Characters character)
    {
        NameSpaceText.text = character.Charactername;
    }
}
