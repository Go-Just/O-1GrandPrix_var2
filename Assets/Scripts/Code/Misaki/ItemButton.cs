using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemButton : MonoBehaviour
{
    public GameData gamedata;
    public TextMeshProUGUI boke_tukkomiitemtext;
    public TextMeshProUGUI jinnkakuitemtext;
    public TextMeshProUGUI kannseidoitemtext;
    public TextMeshProUGUI b_tUseItemText;
    public TextMeshProUGUI jinnUseItemText;
    public TextMeshProUGUI kannUseItemText;
    

    public void OnClickSelectButton()
    {
        if (0 <= gamedata.boke_tukkomiitem)
        {
            gamedata.boke_tukkomiitem = gamedata.boke_tukkomiitem - gamedata.boke_tukkomiUseItem;
            gamedata.boke_tukkomiUseItem = 0;
            b_tUseItemText.text = gamedata.boke_tukkomiUseItem.ToString();
            boke_tukkomiitemtext.text = gamedata.boke_tukkomiitem.ToString();
        }
        if (0 <= gamedata.jinnkakuitem)
        {
            gamedata.jinnkakuitem = gamedata.jinnkakuitem - gamedata.jinnkakuUseItem;
            gamedata.jinnkakuUseItem = 0;
            jinnUseItemText.text = gamedata.jinnkakuUseItem.ToString();
            jinnkakuitemtext.text = gamedata.jinnkakuitem.ToString();
        }
        if (0 <= gamedata.kannseidoitem)
        {
            gamedata.kannseidoitem = gamedata.kannseidoitem - gamedata.kannseidoUseItem;
            gamedata.kannseidoUseItem = 0;
            kannUseItemText.text = gamedata.kannseidoUseItem.ToString();
            kannseidoitemtext.text = gamedata.kannseidoitem.ToString();
        }

    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
