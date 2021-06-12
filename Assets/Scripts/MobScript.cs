using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Mob: MonoBehaviour
{
    public static int HP = 10;
    public static int Speed = 10;

    public void Move()
    {
        float x = 0, y = 0;
        this.GetComponent<Transform>().Translate(new Vector3(x+Speed, y+Speed, 0));
    }

    public void Damage(int PlayerDamage)
    {
        HP -= PlayerDamage;
    }
}

public interface LevelHard
{
    public void setHP();
    public void setSpeed();
}

class Level1 : LevelHard
{
    int Heals = 10;
    int Speed = 0;

    public void setHP()
    {
        Mob.HP += Heals;
    }

    public void setSpeed()
    {
        Mob.Speed += Speed;
    }
}

class Level2 : LevelHard
{
    int Heals = 15;
    int Speed = 5;

    public void setHP()
    {
        Mob.HP += Heals;
    }

    public void setSpeed()
    {
        Mob.Speed += Speed;
    }
}

class Level3 : LevelHard
{
    int Heals = 20;
    int Speed = 10;

    public void setHP()
    {
        Mob.HP += Heals;
    }

    public void setSpeed()
    {
        Mob.Speed += Speed;
    }
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
        Instantiate(Model);
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
    int Speed = 1;

    public Ork(GameObject obj)
    {
        Model = obj;
        HP();
        Move();
        Instantiate(Model);
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
    int Speed = 100;

    public Troll(GameObject obj)
    {
        Model = obj;
        HP();
        Move();
        Instantiate(Model);
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
public class MobScript : MonoBehaviour
{
    public int setLevelHard;

    public GameObject Goblin, Ork, Troll;
    LevelHard LevelHard;
    Mob mob;
    void Start()
    {
        switch (setLevelHard)
        {
            case 1:
                LevelHard = new Level1();
                break;
            case 2:
                LevelHard = new Level2();
                break;
            case 3:
                LevelHard = new Level3();
                break;
            default:
                LevelHard = new Level3();
                break;

        }

        int setMob = Random.Range(0, 3);
        switch (setMob)
        {
            case 0:
                mob = new Goblin(Goblin);
                break;
            case 1:
                mob = new Ork(Ork);
                break;
            case 2:
                mob = new Troll(Troll);
                break;
            default:
                mob = new Goblin(Goblin);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
