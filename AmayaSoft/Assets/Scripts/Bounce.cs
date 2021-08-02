using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Bounce : MonoBehaviour
{
    void Start()
    {
        BounceEffect();
    }
    void BounceEffect()
    {
        transform.DOShakeScale(2.0f, strength: new Vector3(1.0f, 1.0f, 1.0f), vibrato: 2, randomness: 1, fadeOut: true);
    }
    
}
