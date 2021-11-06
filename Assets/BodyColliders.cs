using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyColliders : MonoBehaviour
{
    OxygenManager oxyManager;
    ParticleSystem particle;
    void Start()
    {
        oxyManager = OxygenManager.inst;
        particle = GetComponentInChildren<ParticleSystem>();
        Debug.Log(particle.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("obstacle"))
        {
            oxyManager.DamagedByObs();
            other.tag = "after";
          
        }
        if (other.CompareTag("after"))
        {
            if (particle.isPlaying == false)
                particle.Play();
            else
            {
                particle.Stop();
                particle.Play();
            }
        }
    }

}
