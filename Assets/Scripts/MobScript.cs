using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobScript : MonoBehaviour
{

    public int HP, Speed;
    void Start()
    {
        HP = Mob.HP;
        Speed = Mob.Speed;
        Mob.HP = 0;
        Mob.Speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(HP <= 0)
        {
            Destroy(this.gameObject);
            GameManager.MobOnArena--;
        }
    }

    public void Damage()
    {
        HP -= 10;
    }
    private void OnMouseDown()
    {
        Damage();
    }
}
