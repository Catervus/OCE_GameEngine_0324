using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamplePlayerScript : MonoBehaviour
{
    [SerializeField]
    private int health;
    [SerializeField]
    private int level;
    public void LoadPlayerData(GameData _data)
    {
        transform.position = new Vector3(_data.playerPosition[0], _data.playerPosition[1], _data.playerPosition[2]);

        health = _data.playerHealth;
        level = _data.playerLevel;
    }

    public void SavePlayerData(GameData _data)
    {
        _data.playerPosition[0] = transform.position.x;
        _data.playerPosition[1] = transform.position.y;
        _data.playerPosition[2] = transform.position.z;

        _data.playerHealth = health;
        _data.playerLevel = level;
    }
}
