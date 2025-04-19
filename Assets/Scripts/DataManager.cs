using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public string playerName;
    public string bestScoreText = "Best Score : Name : 0";
    public int bestScore = 0;

    public void Awake()
    {

        if (Instance != null) {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    class SaveData {

        public string bestScoreText = "Best Score : Name : 0";
        public int bestScore = 0;

    }

    public void SavePlayerData() { 

        SaveData saveData = new SaveData();
        saveData.bestScoreText = bestScoreText;
        saveData.bestScore = bestScore;

        string json = JsonUtility.ToJson(saveData);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);

    }

    public void LoadPlayerData()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            bestScoreText = data.bestScoreText;
            bestScore = data.bestScore;
        }

    }

}
