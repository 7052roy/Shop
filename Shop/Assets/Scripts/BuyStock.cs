using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BuyStock : MonoBehaviour {

    public Canvas stockCanvas;
    bool stockOpen = false;
    public Text stockText;
    // Use this for initialization
    void Start()
    {
        PlayerPrefs.SetInt("Rct", 5);
        int stock = PlayerPrefs.GetInt("Rct");
        PlayerPrefs.SetInt("CoasterPlanet", 5);
        int stock1 = PlayerPrefs.GetInt("CoasterPlanet");
        stockText.text = "CoasterPlanet :" + stock1.ToString() + "\nRct :" + stock.ToString();
    }

    public void AddStockcoaster()
    {
        PlayerPrefs.SetInt("CoasterPlanet", PlayerPrefs.GetInt("CoasterPlanet") + 1);
    }

    // Update is called once per frame
    public void InfoPanel()
    {
        Debug.Log("test");
        if (stockOpen == false)
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
