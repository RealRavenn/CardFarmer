using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CostTotal : MonoBehaviour {

    public static int total = 50;
    public Text costText;

    void Start()
    {

    }

    void Update()
    {
        total = 50 - (BeeCost.BeeTotal + CornCost.CornTotal + FlyCost.FlyTotal + PotatoCost.PotatoTotal + RaindropCost.RaindropTotal + SickleCost.SickleTotal + SunCost.SunTotal); // Add the cost total from each card here
        Debug.Log(total);

        costText.text = total.ToString();
    }

}
