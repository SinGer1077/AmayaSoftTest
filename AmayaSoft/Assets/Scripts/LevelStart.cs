using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelStart : MonoBehaviour
{
    public TextMeshProUGUI level_target_message;
    public string level_target;
    public int cells_count;
    public LevelData levelData;

    public List<string> session_values;

    //нормальная версия
    private Queue<Level> _game_levels;
    private Level _current_level;

    void Awake()
    {
        cells_count = 6;
        while (session_values.Count < cells_count)
        {
            string value = levelData.vocabulary[Random.Range(0, levelData.vocabulary.Length)];
            if (!session_values.Contains(value))
            {
                session_values.Add(value);
            }
        }
        
        level_target = session_values[Random.Range(0, session_values.Count)];      
        level_target_message.SetText("Find "+level_target);
        //
        _game_levels.Enqueue(new Level(3, LevelDifficulty.Low));
        _game_levels.Enqueue(new Level(6, LevelDifficulty.Medium));
        _game_levels.Enqueue(new Level(9, LevelDifficulty.High));
    }
    void Start()
    {
        _current_level = _game_levels.Dequeue();
        StartLevel(_current_level);
    }
    void StartLevel(Level _current_level)
    {

    }
}
