using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;

public class CreateGrid : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private GameObject gameController;         
    private Level Current_Level;
   
    public void PopulateGrid()
    {
        ClearGrid();
        Current_Level = gameController.GetComponent<GameStart>().Current_Level;
        GameObject newObj;
        for (int i=0; i < Current_Level.Values_on_level_count; i++)
        {
            newObj = (GameObject)Instantiate(FormPrefab(i), transform);
            newObj.AddComponent<LayoutElement>();            
        }
    }
    void ClearGrid()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
    }
    GameObject FormPrefab(int index)
    {
        Transform backgroundOfPrefab = prefab.transform.Find("CellBackground");
        backgroundOfPrefab.GetComponent<Image>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

        Transform imageOfPrefab = prefab.transform.Find("CellValueImage");        
        imageOfPrefab.GetComponent<Image>().sprite = Current_Level.Session_values[index].CardSprite;

        prefab.GetComponent<CellData>().Cell_Data = Current_Level.Session_values[index];
        return prefab;
    }
}

