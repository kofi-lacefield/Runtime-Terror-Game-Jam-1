﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class score : MonoBehaviour
{
    public static score instance;
    
    int ingredient;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void change(int ingredientValue)
    {
        ingredient += ingredientValue;
        //text.text = "Ingredients Collected:" + ingredient.ToString();

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
