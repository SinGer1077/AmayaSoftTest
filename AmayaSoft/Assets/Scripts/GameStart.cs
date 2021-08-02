using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameStart : MonoBehaviour
{    
    public string level_target;
    public int cells_count;
    public LevelData levelData;

    public List<string> session_values;

    //нормальная версия
    private Queue<Level> _game_levels;
    private Level _current_level;
    [SerializeField] private CardBundleData[] card_types;
    [SerializeField] private TextMeshProUGUI level_target_message;


    void Awake()
    {       
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
        _current_level.Start(card_types);
        level_target_message.SetText("Find " + _current_level.Level_target.Identifier);
    }
}
