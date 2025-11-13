using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IndicationUseItem : MonoBehaviour
{
    public TextMeshProUGUI ItemSpaceText;
    public TextMeshProUGUI UseItemSpaceText;
    public GameData gameData;
    public AllCharacters allCharacters;
    private bool isStart;
    // Start is called before the first frame update
    void Start()
    {

        gameData.Item = 5;
        gameData.UseItemCount = 0;
        isStart = false;
        allCharacters.isCharacterLoaded += () =>
        {
            IndicationText();
            isStart = true;
        };
    }

    // Update is called once per frame
    void Update()
    {
        if (isStart)
        {
            IndicationText();
        }
    }

    void IndicationText()
    {
        ItemSpaceText.text = gameData.Item.ToString();
        UseItemSpaceText.text = gameData.UseItemCount.ToString();
    }
}
