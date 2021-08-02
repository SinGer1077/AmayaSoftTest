using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    void Start()
    {
        FadeOutEffect();
    }

    void FadeOutEffect()
    {
        GetComponent<Image>().DOFade(1.0f, 2.0f);
    }
}
