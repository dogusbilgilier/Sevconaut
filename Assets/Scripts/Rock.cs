using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Hitable
{
    Material mat;
    void Start()
    {
        RandomForceAndTransform();
        transform.position = new Vector3(Random.Range(-0.7f, .7f), Random.Range(0.6f, 1f), 100);
        mat = GetComponent<MeshRenderer>().material;
        mat.SetFloat("_Smoothness", Random.Range(0f, 1f));
        mat.SetFloat("_Metallic", Random.Range(0f, 1f));
    }
}
