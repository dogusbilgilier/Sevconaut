using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float oxygen = 100;
    public static Player inst;
    OxygenManager oxygenManager;
    
    private void Awake()
    {
        oxygen = 100;
        inst = this;
    }
    private void Start()
    {
        oxygenManager = OxygenManager.inst;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("tube"))
        {
            Debug.Log("Tube");
            oxygenManager.OxygenTaken();
            Destroy(other.gameObject);
        }
        if (other.CompareTag("obstacle"))
        {
            oxygenManager.DamagedByObs();
          
        }
    }


    private void Update()
    {

    }
}
