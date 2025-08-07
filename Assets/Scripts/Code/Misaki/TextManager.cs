using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    public GameData gamedata;
    public TextMeshProUGUI boke_tukkomiitemtext;
    public TextMeshProUGUI jinnkakkuitemtext;
    public TextMeshProUGUI kannseidoitemtext;
     public TextMeshProUGUI b_tUseItemText;
    public TextMeshProUGUI jinnUseItemText;
    public TextMeshProUGUI kannUseItemText;


    void Start()
    {
        gamedata.boke_tukkomiitem = 100;
        gamedata.jinnkakuitem = 100;
        gamedata.kannseidoitem = 100;
        gamedata.boke_tukkomiUseItem = 0;
        gamedata.jinnkakuUseItem = 0;
        gamedata.kannseidoUseItem = 0;

        
        boke_tukkomiitemtext.text = gamedata.boke_tukkomiitem.ToString();
        jinnkakkuitemtext.text = gamedata.jinnkakuitem.ToString();
        kannseidoitemtext.text = gamedata.kannseidoitem.ToString(); 
        b_tUseItemText.text = gamedata.boke_tukkomiUseItem.ToString();
        jinnUseItemText.text = gamedata.jinnkakuUseItem.ToString();
        kannUseItemText.text = gamedata.kannseidoUseItem.ToString(); 

    }
    void Update()
    {
        
    }
}
