using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitable : MonoBehaviour
{
    Rigidbody _rigidbody;
    float minForce, maxForce;
    public float force;

    void Update()
    {
        if (transform.position.z < 0 ||
            transform.position.y < -20 ||
            transform.position.y > 20 ||
            transform.position.x > 20 ||
            transform.position.x < -20)
        {
            Destroy(gameObject);
        }

        
    }

    public void RandomForceAndTransform()
    {
        minForce = 300;
        maxForce = 700;
        force = Random.Range(minForce, maxForce);

        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.AddForce(Vector3.back * force);
        transform.localScale = Vector3.one * Random.Range(0.05f, 0.15f);
        _rigidbody.angularVelocity = new Vector3(Random.Range(0f, 360f), Random.Range(0f, 360f), Random.Range(0f, 360f));

    }
}
