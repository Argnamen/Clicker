using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject BaseMob;
    
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

    }
}
