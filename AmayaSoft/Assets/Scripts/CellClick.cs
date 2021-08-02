using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CellClick : MonoBehaviour
{
    public GameObject gameController;
    public string this_value;
    public GameObject childImage;
    void Awake()
    {
        gameController = GameObject.Find("GameController");
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
        
    }
    public void Lose()
    {
        childImage.transform.DOShakePosition(2.0f, strength: new Vector3(4, 0, 0), vibrato: 5, randomness: 1, snapping: false, fadeOut: true);
    }
}
