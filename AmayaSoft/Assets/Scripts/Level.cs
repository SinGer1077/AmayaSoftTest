using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level
{
    //количество ячеек на уровне
    [SerializeField] private int _variants_on_level_count;
    public int Variants_on_level_count
    {
        get { return _variants_on_level_count; }
        set
        {
            if (value < 0)
            {
                throw new Exception("Количество ячеек на уровне не может быть отрицательным");
            }
            else
            {
                _variants_on_level_count = value;
            }
        }
    }

    //сложность уровня
    [SerializeField] private LevelDifficulty _difficulty_of_level;
    public LevelDifficulty Difficulty_of_level { get; set; }
          

    public Level(int variants_count, LevelDifficulty difficulty)
    {
        Variants_on_level_count = variants_count;
        Difficulty_of_level = difficulty;
    }

   


}
