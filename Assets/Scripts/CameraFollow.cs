using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    Vector3 desiredPosition;
    float x, y, z;
    [Range(0, 1)]
    public float followX, followY, followZ;
    [Range(0, 100)]
    public float offsetZ, offsetY;

    private void LateUpdate()
    {
        if (target)
        {
            desiredPosition = target.position;

            x = Mathf.Lerp(transform.position.x, desiredPosition.x, followX);
            y = Mathf.Lerp(transform.position.y, desiredPosition.y + offsetY, followY);
            z = Mathf.Lerp(transform.position.z, desiredPosition.z - offsetZ, followZ);

            transform.position = new Vector3(x, y, z);
        }

    }

    void WhenUfoComes()
    {

    }
}
