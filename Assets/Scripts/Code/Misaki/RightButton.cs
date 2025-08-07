using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.TextCore.Text;
using Unity.VisualScripting;

public class RightButton : MonoBehaviour
{
    public GameData gamedata;
    public TextMeshProUGUI Character;
    public TextMeshProUGUI boke_tukkomiitemtext;
    public TextMeshProUGUI jinnkakuitemtext;
    public TextMeshProUGUI kannseidoitemtext;
    public TextMeshProUGUI b_tUseItemText;
    public TextMeshProUGUI jinnUseItemText;
    public TextMeshProUGUI kannUseItemText;

    void Start()
    {

    }


    public void OnClickRightButton()
    {
        gamedata.IndexCounter = (gamedata.IndexCounter + 1) % gamedata.CharactersList.Count;
        UpdateCharacterDisplay();

    }
    void UpdateCharacterDisplay()
    {
        Character.text = gamedata.CharactersList[gamedata.IndexCounter].Charactername + "\n" +
                         gamedata.CharactersList[gamedata.IndexCounter].CharacterID.ToString() + "\n" +
                         gamedata.CharactersList[gamedata.IndexCounter].boke_tukkomi.ToString() + "\n" +
                         gamedata.CharactersList[gamedata.IndexCounter].jinnkaku.ToString() + "\n" +
                         gamedata.CharactersList[gamedata.IndexCounter].kannseido.ToString();


    }


    public void OnClickboke_tukkomiButton2()
    {

        if (0 < gamedata.boke_tukkomiUseItem && gamedata.boke_tukkomiUseItem <= gamedata.boke_tukkomiitem)
        {
            gamedata.boke_tukkomiUseItem--;
            b_tUseItemText.text = gamedata.boke_tukkomiUseItem.ToString();
        }

       

    }
    public void OnClickjinnkakuButton2()
    {
        if (0 < gamedata.jinnkakuUseItem && gamedata.jinnkakuUseItem <= gamedata.jinnkakuitem)
        {
            gamedata.jinnkakuUseItem--;
            jinnUseItemText.text = gamedata.jinnkakuUseItem.ToString();
        }
    }
    public void OnClickkannseidoButton2()
    {
        if (0 < gamedata.kannseidoUseItem && gamedata.kannseidoUseItem <= gamedata.kannseidoitem)
        {
            gamedata.kannseidoUseItem--;
            kannUseItemText.text = gamedata.kannseidoUseItem.ToString();
        }
    }
        
    }
    
     
    
    


