using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IndicationCharacterName : MonoBehaviour
{
    public GameData gameData;
    public TextMeshProUGUI NameSpaceText;

    // Start is called before the first frame update
    void Start()
    {
        indicationCharacterName(gameData.CharactersList[0]);
    }

    private void indicationCharacterName(Characters character)
    {
        NameSpaceText.text = character.Charactername;
    }
}
