using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameObjectScore
{
    public static List<MobScript> obj = new List<MobScript>();
    public static void Score(MobScript gameObject)
    {
        obj.Add(gameObject);
    }
    public static void RemoveScore(MobScript gameObject)
    {
        obj.Remove(gameObject);
    }
}

public class GameManager : MonoBehaviour
{

    public static int MobOnArena = 0;
    public static int PlayerPoint = 0;
    public static int records = 0;
    public int SpawnSpeed = 0;
    public int LevelHard = 5;
    public GameObject FreezButton, KillButton;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnMob.setSpawnSpeed = SpawnSpeed;
        SpawnMob.setLevelHard = LevelHard;
        if (GameObjectScore.obj.Count == 10)
        {
            RecordsScript.setRecords(records);
            ButtonBonusScript.timeFreez = 30000f;
            SpawnMob.setFreez = 0f;
            //gag
            SceneManager.LoadScene("MainMenu");
            print("GameEnd");
        }
        else
        {
            switch (PlayerPoint)
            {
                case 2:
                    FreezButton.SetActive(true);
                    break;
                case 4:
                    KillButton.SetActive(true);
                    break;
            }
        }
        switch (records)
        {
            case 10:
                LevelHard = 1;
                break;
            case 15:
                SpawnSpeed = 4;
                break;
            case 20:
                LevelHard = 2;
                break;
            case 25:
                SpawnSpeed = 3;
                break;
            case 35:
                LevelHard = 3;
                break;
            case 40:
                SpawnSpeed = 2;
                break;
        }
    }
}
