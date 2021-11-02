using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : Hitable
{

    void Start()
    {
        RandomForceAndTransform();
        transform.position = new Vector3(Random.Range(-0.7f, .7f), Random.Range(0.7f, 1f), 100);
    }
}
