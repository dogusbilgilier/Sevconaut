using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    Rigidbody _rigidbody;
     float minForce, maxForce;
    public float force;
    Material mat;

    void Start()
    {
        /*mat = GetComponent<MeshRenderer>().material;
        mat.SetFloat("_Smoothness", Random.Range(0f, 1f));
        mat.SetFloat("_Metallic", Random.Range(0f, 1f));*/
        RandomForceAndTransform();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z<0)
        {
            Destroy(gameObject);
        }
    }

    void RandomForceAndTransform()
    {
        minForce = 100;
        maxForce = 500;
        force = Random.Range(minForce, maxForce);
       
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.AddForce(Vector3.back * force);
        transform.localScale = Vector3.one * Random.Range(0.05f, 0.4f);
        _rigidbody.angularVelocity = new Vector3(Random.Range(0f, 360f), Random.Range(0f, 360f), Random.Range(0f, 360f));

    }
}
