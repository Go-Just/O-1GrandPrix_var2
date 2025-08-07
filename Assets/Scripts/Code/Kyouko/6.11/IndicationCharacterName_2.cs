using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IndicationCharacterName_2 : MonoBehaviour
{
    public GameData gameData;
    public TextMeshProUGUI NameSpaceText;
    private int IndexCounter;
    void Start()
    {
        IndexCounter = 0;
        indicationCharacterName(gameData.CharactersList[IndexCounter]);
    }

    // Update is called once per frame
    void Update()
    {
        ChangeCharacterName();
    }

    private void ChangeCharacterName()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (IndexCounter == 0)//最初のインデックス(List[0])を参照してたら一番最後のインデックスにいるキャラクターを参照する。
            {
                IndexCounter = gameData.CharactersList.Count - 1; //Countを使うことでリストの長さを持ってこれる。インデックスは0~だから-1して最後のインデックス参照になる
            }
            else
            {
                IndexCounter--;
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (IndexCounter == gameData.CharactersList.Count - 1)//最後のインデックスを参照してたら一番最初のインデックスにいるキャラクターを参照する。
            {
                IndexCounter = 0;
            }
            else
            {
                IndexCounter++;
            }
        }
        indicationCharacterName(gameData.CharactersList[IndexCounter]);
    }
    
    private void indicationCharacterName(Characters character)
    {
        NameSpaceText.text = character.Charactername;
    }
}
