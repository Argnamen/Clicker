using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject BaseMob;
    public static int MobOnArena = 0;
    

    void SpawnMob()
    {
        Instantiate(BaseMob);
    }
    void Start()
    {
        SpawnMob();
    }

    // Update is called once per frame
    void Update()
    {
        if (MobOnArena >= 10)
            print("GameEnd");
    }
}
