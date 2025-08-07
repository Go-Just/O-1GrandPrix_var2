using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemCount : MonoBehaviour
{
    public GameData gamedata;
    public AllCharacters allCharacters;
    private bool isStart;
    public TextMeshProUGUI boketukkomiitem;
    public TextMeshProUGUI jinnkakuitem;
    public TextMeshProUGUI kannseidoitem;




    void Start()
    {

        Debug.Log($"ItemCount = {gamedata.boke_tukkomiitem}");
        isStart = false;
        allCharacters.isCharacterLoaded += () =>
        {
            gamedata.IndexCounter = 0;
            indicationCharacterStatus(gamedata.CharactersList[gamedata.IndexCounter]);
            isStart = true;
        };
         Debug.Log($"ItemCount = {gamedata.jinnkakuitem}");
        isStart = false;
        allCharacters.isCharacterLoaded += () =>
        {
            gamedata.IndexCounter = 0;
            indicationCharacterStatus(gamedata.CharactersList[gamedata.IndexCounter]);
            isStart = true;
        };
         Debug.Log($"ItemCount = {gamedata.kannseidoitem}");
        isStart = false;
        allCharacters.isCharacterLoaded += () =>
        {
            gamedata.IndexCounter = 0;
            indicationCharacterStatus(gamedata.CharactersList[gamedata.IndexCounter]);
            isStart = true;
        };
    }

    // Update is called once per frame
    void Update()
    {
        if (isStart)
        {
            indicationCharacterStatus(gamedata.CharactersList[gamedata.IndexCounter]);
            
        }
    }
    private void indicationCharacterStatus(Characters character)
    {
        boketukkomiitem.text = gamedata.boke_tukkomiitem.ToString();
        jinnkakuitem.text = gamedata.jinnkakuitem.ToString();
        kannseidoitem.text = gamedata.kannseidoitem.ToString();
    }
}
