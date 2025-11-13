using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersImageList : MonoBehaviour
{
    public GameData gameData;
    public GameObject CharactersImage;
    public GameObject Canvas;
    public AllCharacters allCharacters;
    private int CharacterCount;
    // Start is called before the first frame update
    void Start()
    {
        allCharacters.isCharacterLoaded += () =>
        {
            CharacterCount = gameData.CharactersList.Count;
            for (int i = 0; i < CharacterCount; i++)
            {
                if (gameData.CharactersList[i].isGet == true)
                {
                    GameObject CharacterImage = Instantiate(CharactersImage, Canvas.transform);
                    CharacterImage.transform.localPosition = new Vector2(0, 0);
                    CharacterImage.transform.rotation = Quaternion.identity;
                }
            }
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
