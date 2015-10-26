﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Stock : MonoBehaviour {


    public Canvas stockCanvas;
    bool stockOpen = false;
    public Text stockText;
	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("rct", 5);
        int stock = PlayerPrefs.GetInt("rct");
        stockText.text = "rct :" + stock.ToString();
	}
	
	// Update is called once per frame
	public void InfoPanel () {
        Debug.Log("test");
	    if(stockOpen == false)
        {
            stockOpen = true;
            stockCanvas.enabled = true;
        }
        else if (stockOpen == true)
        {
            stockOpen = false;
            stockCanvas.enabled = false;
        }
    }
}
