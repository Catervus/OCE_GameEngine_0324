using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GameData
{
    public int playerLevel;
    public int playerHealth;
    public float[] playerPosition;
    
    public GameData()
    {
        playerLevel = 0;
        playerHealth = 0;
        playerPosition = new float[3];
    }

    public GameData(int _playerlvl, int _playerhp, float[] _playerpos)
    {
        this.playerLevel = _playerlvl;
        this.playerHealth = _playerhp;
        this.playerPosition = _playerpos;
    }
}
