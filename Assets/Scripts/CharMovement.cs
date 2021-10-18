using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovement : MonoBehaviour
{
    public float speedHor = 5f;
    public float speedForward = 10f;
    public float clampXMin = float.NegativeInfinity;
    public float clampXMax = float.PositiveInfinity;
    [Range(0f, 0.99f)]
    public float dampingHor;
    private float xGoal;

    private void OnEnable()
    {
        xGoal = transform.position.x;
    }

    private void Update()
    {
        xGoal += InputManager.inst.deltaDir.x * speedHor*0.1f;
        xGoal = Mathf.Clamp(xGoal, clampXMin, clampXMax);

        transform.position += new Vector3(0f, 0f, speedForward * Time.deltaTime);
        if (dampingHor < 0.1f)
            transform.position = new Vector3(xGoal, transform.position.y, transform.position.z);
        else
            transform.position = new Vector3(Mathf.Lerp(transform.position.x, xGoal, (1f - dampingHor) * Time.deltaTime * 30f), transform.position.y, transform.position.z);
    }
}
