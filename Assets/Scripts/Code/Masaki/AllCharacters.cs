using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.AddressableAssets;

public class AllCharacters : MonoBehaviour
{
    public GameData gameData;

    async void Awake()
    {
        gameData.CharactersList = new List<Characters>();
        
        await CharacterLoad();

        foreach(var Chara in gameData.CharactersList){
            Debug.Log(Chara.Charactername);
        }
    }

    public async Task CharacterLoad(){
        var handle = Addressables.LoadAssetsAsync<Characters>("geininn", character =>
        {
            gameData.CharactersList.Add(character);
        });
        await handle.Task;
    }
}
