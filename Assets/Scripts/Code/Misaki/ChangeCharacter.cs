using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Unity;

public class ChangeCharacter : MonoBehaviour
{
    public GameData gamedata;
    public TextMeshProUGUI Character;
    private int currentIndex = 0;
   
    
    void Start()
    {
        UpdateCharacterDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentIndex = (currentIndex + 1) % gamedata.CharactersList.Count;
            UpdateCharacterDisplay();

        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
             currentIndex = (currentIndex - 1) % gamedata.CharactersList.Count;
            UpdateCharacterDisplay();
        }
    }
        void UpdateCharacterDisplay()
        {
            Character.text = gamedata.CharactersList[currentIndex].Charactername;
        }
    
}
