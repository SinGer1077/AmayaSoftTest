using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{    
    void Start()
    {
        FadeInEffect();
    }
    
    void FadeInEffect()
    {
        GetComponent<Text>().DOFade(1.0f, 2.0f);
    }
}
