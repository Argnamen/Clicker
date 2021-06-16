using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobScript : MonoBehaviour
{

    public float Speed;
    public float HP;
    void Start()
    {
        HP = Mob.HP;
        Speed = Mob.Speed;
        Mob.HP = 0;
        Mob.Speed = 0;
        GetComponent<Rigidbody>().velocity = new Vector3(Speed, Speed, 0f);
        GameObjectScore.Score(this.GetComponent<MobScript>());
    }

    // Update is called once per frame
    void Update()
    {
        if(HP <= 0)
        {
            GameManager.records++;
            GameObjectScore.RemoveScore(this.GetComponent<MobScript>());
            Destroy(this.gameObject);
            GameManager.PlayerPoint++;
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
