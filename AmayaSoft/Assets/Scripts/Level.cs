using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Level
{
    //количество ячеек на уровне
    [SerializeField] private int _values_on_level_count;
    public int Values_on_level_count
    {
        get { return _values_on_level_count; }
        set
        {
            if (value < 0)
            {
                throw new Exception("Количество ячеек на уровне не может быть отрицательным");
            }
            else
            {
                _values_on_level_count = value;
            }
        }
    }

    //сложность уровня
    [SerializeField] private LevelDifficulty _difficulty_of_level;
    public LevelDifficulty Difficulty_of_level
    {
        get { return _difficulty_of_level; }
        set { _difficulty_of_level = value; }
    }

    //тип данных на уровне
    private CardBundleData _type_of_card;
    public CardBundleData Card_Type
    {
        get { return _type_of_card; }
        set { _type_of_card = value;}
    }

    //данные, которые будут задействованы в уровне
    private List<CardData> _session_values;
    public List<CardData> Session_values
    {
        get { return _session_values; }
        set {_session_values = value; }
    }

    //цель текущего уровня
    private CardData _session_target;
    public CardData Level_target
    {
        get { return _session_target; }
        set { _session_target = value; }
    }

    public Level(int variants_count, LevelDifficulty difficulty)
    {
        Values_on_level_count = variants_count;
        Difficulty_of_level = difficulty;
    }
    public void Start(CardBundleData[] _card_data_types)
    {
        SetRandomCardType(_card_data_types);
        SetRandomCardsOnLevel();
        ChooseRandomTarget();
    }
    void SetRandomCardType(CardBundleData[] _card_data_types)
    {
        Card_Type = _card_data_types[UnityEngine.Random.Range(0, _card_data_types.Length)];
    }
    void SetRandomCardsOnLevel()
    {
        Session_values = new List<CardData>();
        while (Session_values.Count < Values_on_level_count)
        {
            CardData value = Card_Type.CardDataArray[UnityEngine.Random.Range(0, Card_Type.CardDataArray.Length)];
            if (!Session_values.Contains(value))
            {
                Session_values.Add(value);
            }
        }
    }
    void ChooseRandomTarget()
    {
        Level_target = Session_values[UnityEngine.Random.Range(0, Session_values.Count)];
    }

   


}
