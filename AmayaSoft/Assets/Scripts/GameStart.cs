using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{     
    [SerializeField] private List<Level> _game_levels_list;
    private int Current_Level_Number = 0;    
    private Level _current_level;
    private List<CardData> previousCards = new List<CardData>();
    public Level Current_Level => _current_level;
    [SerializeField] private CardBundleData[] card_types;
    [SerializeField] private Text level_target_message;
    [SerializeField] private GameObject grid;

    [SerializeField] private Button restartButton;
    [SerializeField] private GameObject tapPanel;

    void Start()
    {        
        StartLevel();
    }
    void StartLevel()
    {
        restartButton.gameObject.SetActive(false);
        tapPanel.SetActive(false);

        _current_level = _game_levels_list[Current_Level_Number];
        _current_level.Start(card_types, previousCards);
        level_target_message.text = "Find " + _current_level.Level_target.Identifier;
        previousCards.Add(_current_level.Level_target);

        grid.GetComponent<CreateGrid>().PopulateGrid();
    }
    public void EndLevel()
    {
        if (Current_Level_Number < _game_levels_list.Count - 1)
        {
            Current_Level_Number++;
            Invoke("StartLevel", 3.0f);
        }
        else
        {
            EndGame();
        }
    }
    void EndGame()
    {
        restartButton.gameObject.SetActive(true);
        tapPanel.SetActive(true);
    }
    public void RestartGame()
    {
        Current_Level_Number = 0;
        StartLevel();
    }
}
