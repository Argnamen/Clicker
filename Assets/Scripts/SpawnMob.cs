using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Mob: MonoBehaviour
{
    public static int HP = 10;
    public static int Speed = 0;

    public void spawnMob(GameObject Model)
    {
        float x = Random.Range(-2f, 2f), y = Random.Range(-3f, 4f);
        Vector3 spawnPoint = new Vector3(x, y, -0.5f);
        Instantiate(Model, spawnPoint, Quaternion.identity);
        ControllAnimation();
    }

    public void ControllAnimation()
    {
        
    }
    
}

public abstract class LevelHard
{
    public abstract int Heals { get; }
    public abstract int Speed { get; }

    public LevelHard()
    {
        setHP();
        setSpeed();
    }


    public void setHP()
    {
        Mob.HP += Heals;
    }

    public void setSpeed()
    {
        Mob.Speed += Speed;
    }
}

class Level1 : LevelHard
{
    int setHeals = 10;
    int setSpeed = 0;
    public override int Heals { get => setHeals; }
    public override int Speed { get => setSpeed; }
}

class Level2 : LevelHard
{
    int setHeals = 20;
    int setSpeed = 1;
    public override int Heals { get => setHeals; }
    public override int Speed { get => setSpeed; }
}

class Level3 : LevelHard
{
    int setHeals = 30;
    int setSpeed = 2;
    public override int Heals { get => setHeals; }
    public override int Speed { get => setSpeed; }
}

class Goblin: Mob
{
    public GameObject Model;

    int Heals = 10;
    int Speed = 5;


    public Goblin(GameObject obj)
    {
        Model = obj;
        HP();
        Move();
        spawnMob(Model);
    }
    public void HP()
    {
        Mob.HP += Heals;
    }

    public void Move()
    {
        Mob.Speed += Speed;
    }
}

class Ork : Mob
{
    public GameObject Model;

    int Heals = 100;
    int Speed = 3;

    public Ork(GameObject obj)
    {
        Model = obj;
        HP();
        Move();
        spawnMob(Model);
    }
    public void HP()
    {
        Mob.HP += Heals;
    }

    public void Move()
    {
        Mob.Speed += Speed;
    }
}

class Troll : Mob
{
    public GameObject Model;

    int Heals = 5;
    int Speed = 4;

    public Troll(GameObject obj)
    {
        Model = obj;
        HP();
        Move();
        spawnMob(Model);
    }
    public void HP()
    {
        Mob.HP += Heals;
    }

    public void Move()
    {
        Mob.Speed += Speed;
    }
}


public class SpawnMob : MonoBehaviour
{
    public static int setLevelHard;

    public GameObject Goblin, Ork, Troll;

    public float timer = 0;
    public static float setSpawnSpeed = 1;
    public static float setFreez = 1;

    void Spawn()
    {
        int setMob = Random.Range(0, 3);
        switch (setMob)
        {
            case 0:
                new Goblin(Goblin);
                break;
            case 1:
                new Ork(Ork);
                break;
            case 2:
                new Troll(Troll);
                break;
            default:
                new Goblin(Goblin);
                break;
        }
        switch (setLevelHard)
        {
            case 0:
                break;
            case 1:
                new Level1();
                break;
            case 2:
                new Level2();
                break;
            case 3:
                new Level3();
                break;
            default:
                new Level3();
                break;

        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += (Time.deltaTime * setFreez);
        if(setFreez == 0)
            ButtonBonusScript.timeFreez -= Time.deltaTime;
        if (ButtonBonusScript.timeFreez <= 0)
            setFreez = 1;
        if (timer >= setSpawnSpeed)
        {
            Spawn();
            timer = 0;
        }
    }
}
