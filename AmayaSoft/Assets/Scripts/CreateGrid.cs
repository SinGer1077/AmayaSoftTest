using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;

public class CreateGrid : MonoBehaviour
{
    public GameObject prefab;
    public GameObject gameController;
    public int numberToCreate;
    public SpriteAtlas atlas;
    

    private void Start()
    {
        numberToCreate = gameController.GetComponent<LevelStart>().session_values.Count;
        Populate();
    }
    void Populate()
    {
        GameObject newObj;
        for (int i=0; i<numberToCreate; i++)
        {
            newObj = (GameObject)Instantiate(FormPrefab(i), transform);
            newObj.AddComponent<LayoutElement>();
            
        }
    }
    GameObject FormPrefab(int index)
    {
        Transform backgroundOfPrefab = prefab.transform.Find("CellBackground");
        backgroundOfPrefab.GetComponent<Image>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        Transform imageOfPrefab = prefab.transform.Find("CellValueImage");
        string sprite_name = "sprite_letters_" + gameController.GetComponent<LevelStart>().session_values[index];
        imageOfPrefab.GetComponent<Image>().sprite = atlas.GetSprite(sprite_name);
        prefab.GetComponent<CellClick>().this_value = gameController.GetComponent<LevelStart>().session_values[index];
        return prefab;
    }
}

