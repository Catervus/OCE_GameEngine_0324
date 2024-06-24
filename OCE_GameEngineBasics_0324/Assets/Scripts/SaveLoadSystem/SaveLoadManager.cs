using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadManager : MonoBehaviour
{
    private GameData gameData = new GameData();

    // Example
    public GameData GetGameData { get => gameData; }

    // EXAMPLE / TESTING
    [SerializeField]
    private ExamplePlayerScript playerExample;

    public void Start()
    {
        // TEST
        gameData = new GameData(45, 100, new float[] { 0, 0, 100 });
    }
    public void SaveGameData()
    {
        playerExample.SavePlayerData(gameData);
        // levelManager.SaveLevelData(gameData); EXAMPLE
        Debug.Log("Save Game Data!");
        SaveLoadSystem.SaveData(gameData);
    }

    public void LoadGameData()
    {
        Debug.Log("Load Game Data!");
        GameData data = SaveLoadSystem.LoadData();

        if (data == null)
            return;

        gameData = data;

        // Apply data

        // EXAMPLE
        playerExample.LoadPlayerData(data);


    }

}
