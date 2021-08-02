using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextFade : MonoBehaviour, IFade
{
    [SerializeField] private float _end_value;
    [SerializeField] private float _duration;
    void Start()
    {
        FadeEffect(_end_value, _duration);
    }   

    public void FadeEffect(float endValue, float duration)
    {
        GetComponent<Text>().DOFade(endValue, duration);
    }
}
