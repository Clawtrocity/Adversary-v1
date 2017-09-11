using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

    public static GameControl control;

    public int currentDeck;
    public float gold;
    public float deck1;
    public float deck2;
    public float deck3;
    public float deck4;
    public float equipped;
    public float items;
    public float wins;
    public float losses;
    public float totalpoints;
    public string profileName;
    public int profileElo;
    public string enemyName;
    public int enemyDeck;
    public string playerVillain;
    public string enemyVillain;
    public string playerGold;
    public string playerPoints;
    public int playerPointsTracker;
    public int playerGoldTracker;
    public string enemyGold;
    public string enemyPoints;
    public int enemyPointsTracker;
    public int enemyGoldTracker;
    public int TownSlot1;
    public int TownSlot2;
    public int TownSlot3;
    public int TownSlot4;
    public int TownSlot5;
    public int TownSlot6;
    public int TownSlot7;
    public int TownSlot8;
    public int TownSlot9;
    public int TownSlot10;
    public int TownSlot11;
    public int TownSlot12;
    public int TownSlot13;

    void OnEnable()
    {
        Load();
    }
    
    void OnApplicationQuit()
    {
        Save();
    }

    void Awake()
    {

        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }

        string[] names = { "The Joker", "Bane", "Doom", "Magneto", "Loki", "Lex Luthor" };

        enemyDeck = UnityEngine.Random.Range(1, 2);
        enemyName = names.RandomItem();
    }

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        PlayerData data = new PlayerData();
        data.currentDeck = currentDeck;
        data.gold = gold;
        data.deck1 = deck1;
        data.deck2 = deck2;
        data.deck3 = deck3;
        data.deck4 = deck4;
        data.equipped = equipped;
        data.items = items;
        data.wins = wins;
        data.losses = losses;
        data.totalpoints = totalpoints;
        data.profileName = profileName;
        data.profileElo = profileElo;
        data.playerVillain = playerVillain;

        bf.Serialize(file, data);
        file.Close();
    }

    public void Load()
    {
        if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat",FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            currentDeck = data.currentDeck;
            gold = data.gold;
            deck1 = data.deck1;
            deck2 = data.deck2;
            deck3 = data.deck3;
            deck4 = data.deck4;
            equipped = data.equipped;
            items= data.items;
            wins = data.wins;
            losses = data.losses;
            totalpoints = data.totalpoints;
            profileName = data.profileName;
            profileElo = data.profileElo;
            playerVillain = data.playerVillain;
        }
    }

    public void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "Game")
        {
            playerPoints = "Points: " + playerPointsTracker;
            playerGold = "Gold: " + playerGoldTracker;
            enemyPoints = "Points: " + enemyPointsTracker;
            enemyGold = "Gold: " + enemyGoldTracker;
        }
    }
}

[Serializable]
class PlayerData
{
    public int currentDeck;
    public float gold;
    public float deck1;
    public float deck2;
    public float deck3;
    public float deck4;
    public float equipped;
    public float items;
    public float wins;
    public float losses;
    public float totalpoints;
    public string profileName;
    public int profileElo;
    public string playerVillain;
}

public static class ArrayExtensions
{
    // This is an extension method. RandomItem() will now exist on all arrays.
    public static T RandomItem<T>(this T[] array)
    {
        return array[UnityEngine.Random.Range(0, array.Length)];
    }
}