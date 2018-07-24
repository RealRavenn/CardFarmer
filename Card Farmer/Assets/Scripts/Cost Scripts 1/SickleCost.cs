using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SickleCost : MonoBehaviour {

    static public int SickleTotal;
    public bool isPlaced;

    private void Start()
    {
        SickleTotal = 0;
        isPlaced = false;
    }

    void Update()
    {
        SetCostTotal();
    }

    void SetCostTotal()
    {
        if (this.transform.parent.name == "Placement" && Input.GetMouseButtonUp(0) && isPlaced == false)
        {
            SickleTotal += 5;
            isPlaced = true;
        }
    }
}
