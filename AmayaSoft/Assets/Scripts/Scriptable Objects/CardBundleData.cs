using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Card Data", menuName = "Scripts/Scriptable Objects/CardBundleData", order = 1)]
public class CardBundleData : ScriptableObject
{
    [SerializeField] private CardData[] _cardDataArray = null;
    public CardData[] CardDataArray => _cardDataArray;
}
