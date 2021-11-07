using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    public static bool fin;
    public float oxygen = 100;
    public static Player inst;
    OxygenManager oxygenManager;
    public Animator animator;
    Rigidbody rb;
    
    private void Awake()
    {
        oxygen = 100;
        inst = this;
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = transform.GetComponentInChildren<Animator>();
        oxygenManager = OxygenManager.inst;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("tube"))
        {
            other.enabled = false;
            oxygenManager.OxygenTaken(other.GetComponent<OxyTube>().oxygen);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("obstacle"))
        {
            //oxygenManager.DamagedByObs();
        }
        else if (other.CompareTag("fin"))
        {
           
            GetComponent<CharMovement>().enabled = false;
            fin = true;
            Win();
            SpaceShip.inst.Land();
        }
    }

    public void Dead()
    {
        transform.DOMoveY(0.25f, 0);
        animator.SetBool("dead", true);
        GetComponent<CharMovement>().speedForward = 0;
        GetComponent<CharMovement>().speedHor = 0;
        rb.isKinematic = false;
        rb.useGravity = false;
        rb.AddForce(new Vector3(0,0.3f,1)*10, ForceMode.Force);
    }
    public void Win()
    {
        Debug.Log("Win");
    }

}
