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

    }
}
