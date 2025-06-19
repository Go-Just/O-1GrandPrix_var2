using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IndicationCharacterStatus : MonoBehaviour
{
    public GameData gameData;
    public TextMeshProUGUI NameSpaceText;
    public TextMeshProUGUI StatusSpaceText;
    void Start()
    {
        gameData.IndexCounter = 0;
        indicationCharacterStatus(gameData.CharactersList[gameData.IndexCounter]);
    }

    // Update is called once per frame
    void Update()
    {
        indicationCharacterStatus(gameData.CharactersList[gameData.IndexCounter]);
    }

    private void indicationCharacterStatus(Characters character)
    {
        NameSpaceText.text = character.Charactername;
        StatusSpaceText.text = $"ID = {character.CharacterID}\nボケ・ツッコミ = {character.boke_tukkomi}\n完成度 = {character.kannseido}\n人格 = {character.jinnkaku}";
    }
}
