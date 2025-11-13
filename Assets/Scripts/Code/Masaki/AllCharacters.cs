using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.AddressableAssets;
using System;

public class AllCharacters : MonoBehaviour
{
    public GameData gameData;
    public event Action isCharacterLoaded;

    async void Awake()
    {
        gameData.CharactersList = new List<Characters>();

        await CharacterLoad();

        foreach (var Chara in gameData.CharactersList)
        {
            Debug.Log(Chara.Charactername);
        }
    }

    public async Task CharacterLoad()
    {
        var handle = Addressables.LoadAssetsAsync<Characters>("geininn", character =>
        {
            gameData.CharactersList.Add(character);
        });

        gameData.CharactersList.Sort((a, b) => b.CharacterID.CompareTo(a.CharacterID));
        await handle.Task;

        isCharacterLoaded.Invoke();
    }
}
