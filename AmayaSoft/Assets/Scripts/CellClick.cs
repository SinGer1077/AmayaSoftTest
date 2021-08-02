using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CellClick : MonoBehaviour
{
    public GameObject gameController;
    public string this_value;
    public GameObject childImage;
    public ParticleSystem starEffect;
    void Awake()
    {
        gameController = GameObject.Find("GameController");
        starEffect.gameObject.SetActive(false);
    }
    public void Click()
    {
        if (this_value == gameController.GetComponent<LevelStart>().level_target)
        {
            Win();
        }
        else
        {
            Lose();
        }
    }
    public void Win()
    {
        childImage.transform.DOShakeScale(2.0f, strength: new Vector3(1, 1, 1), vibrato: 2, randomness: 1, fadeOut: true);
        starEffect.gameObject.SetActive(true);
    }
    public void Lose()
    {
        childImage.transform.DOShakePosition(2.0f, strength: new Vector3(4, 0, 0), vibrato: 5, randomness: 1, snapping: false, fadeOut: true);
    }
}
