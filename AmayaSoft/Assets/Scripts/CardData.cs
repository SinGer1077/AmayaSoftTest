using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CardData
{
    [SerializeField] private string _identifier = null;
    public string Identifier => _identifier;
    [SerializeField] private Sprite _sprite = null;
    public Sprite CardSprite => _sprite;
}
