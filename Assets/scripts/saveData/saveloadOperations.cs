using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class saveloadOperations
{
    public static void saveToFile()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/saveFile.kusa";
        FileStream stream = File.Create(path);

        formatter.Serialize(stream, globalVar.sd);
        stream.Close();
    }

    public static saveData LoadToGame()
    {
        string path = Application.persistentDataPath + "/saveFile.kusa";
        saveData data = new saveData();
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = File.Open(path, FileMode.Open);

            data = formatter.Deserialize(stream) as saveData;
            stream.Close();
            return data;

        }

        return data;

    }
}
