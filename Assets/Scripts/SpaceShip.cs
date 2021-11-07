using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SpaceShip : MonoBehaviour
{

    public static SpaceShip inst;
    private void Awake()
    {
        inst = this;
    }
    public void Land()
    {
        transform.DOMoveY(4f, 2f).SetEase(Ease.Linear).OnComplete(() => { transform.DOMoveY(2.89f, 2f); });
    }
}
