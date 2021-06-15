using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static int MobOnArena = 0;
    public int SpawnSpeed = 0;
    public int LevelHard = 0;
    public GameObject FreezButton, KillButton;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnMob.setSpawnSpeed = SpawnSpeed;
        SpawnMob.setLevelHard = LevelHard;
        switch (MobOnArena)
        {
            case 10:
                print("GameEnd");
                break;
            case 20:
                FreezButton.SetActive(true);
                break;
            case 30:
                KillButton.SetActive(true);
                break;
        }
    }
}
