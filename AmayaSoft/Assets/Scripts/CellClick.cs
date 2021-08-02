using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CellClick : MonoBehaviour
{
    private GameObject gameController;    
    [SerializeField] private GameObject childImage;
    [SerializeField] private ParticleSystem starEffect;    
    private Level Current_Level;
    void Start()
    {
        gameController = GameObject.Find("GameController");
        Current_Level = gameController.GetComponent<GameStart>().Current_Level;        
        starEffect.gameObject.SetActive(false);
    }
    public void Click()
    {
        if (GetComponent<CellData>().Cell_Data.Identifier == Current_Level.Level_target.Identifier)
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
