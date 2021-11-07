using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    public GameObject[] prefabs;
    public float minRandomTime,maxRandomTime;
    float randomTime;
    void Start()
    {

        randomTime = Random.Range(minRandomTime, maxRandomTime);
        if (!Player.fin)
            InvokeRepeating("InstantiateRock", randomTime, randomTime);
    }

    void InstantiateRock()
    {

        GameObject obstacle= Instantiate(prefabs[Random.Range(0,5)]);
        randomTime = Random.Range(minRandomTime, maxRandomTime);
    }
}
