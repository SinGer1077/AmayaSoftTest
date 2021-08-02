﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateGrid : MonoBehaviour
{
    public GameObject prefab;
    public int numberToCreate;

    private void Start()
    {
        Populate();
    }
    void Populate()
    {
        GameObject newObj;
        for (int i=0; i<numberToCreate; i++)
        {
            newObj = (GameObject)Instantiate(prefab, transform);
            newObj.AddComponent<LayoutElement>();
            
        }
    }
}
