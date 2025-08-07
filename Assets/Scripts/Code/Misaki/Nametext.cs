using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Nametext : MonoBehaviour
{
    public GameData gameData;

    public TextMeshProUGUI Character;

      void Start()
    {
        Character.text = gameData.CharactersList[0].Charactername;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
