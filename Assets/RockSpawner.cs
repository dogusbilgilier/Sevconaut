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
        InvokeRepeating("InstantiateRock", randomTime, randomTime);
    }

    void InstantiateRock()
    {

        GameObject obstacle= Instantiate(prefabs[Random.Range(0,5)]);
        obstacle.transform.position = new Vector3(Random.Range(-0.7f, .7f), Random.Range(0.6f, 1f), 60);
        randomTime = Random.Range(minRandomTime, maxRandomTime);
    }
}
