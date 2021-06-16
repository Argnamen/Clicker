using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBonusScript : MonoBehaviour
{
    public static float timeFreez = 0;
    public void FreezBonus()
    {
        this.gameObject.SetActive(false);
        SpawnMob.setFreez = 0;
        timeFreez = 3f;
        GameManager.PlayerPoint = 0;
    }

    public void KillAllBonus()
    {
        GameManager.MobOnArena = 0;
        foreach (MobScript obj in GameObjectScore.obj)
        {
            obj.HP = 0;
        }
        this.gameObject.SetActive(false);
        GameManager.PlayerPoint = 0;
    }
}
