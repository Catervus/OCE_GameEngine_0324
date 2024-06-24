using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveLoadSystem
{

    private static string fileName = "/gamedata.fun";
    public static void SaveData(GameData _data)
    {
        string path = Application.persistentDataPath + fileName;
        FileStream stream = new FileStream(path, FileMode.OpenOrCreate);

        BinaryFormatter formatter = new BinaryFormatter();

        formatter.Serialize(stream, _data);

        stream.Close();
    }

    public static GameData LoadData()
    {
        string path = Application.persistentDataPath + fileName;
        if(File.Exists(path) == false)
        {
            Debug.LogWarning("File to load does not exist!");
            return null;
        }

        FileStream stream = new FileStream(path, FileMode.Open);

        BinaryFormatter formatter = new BinaryFormatter();

        GameData data = formatter.Deserialize(stream) as GameData;

        stream.Close();

        return data;

    }
}
