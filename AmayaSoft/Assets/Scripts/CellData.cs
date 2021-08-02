using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellData : MonoBehaviour
{
    [SerializeField]private CardData _cardData = null;
    public CardData Cell_Data
    {
        get { return _cardData; }
        set { _cardData = value; }
    }
}
