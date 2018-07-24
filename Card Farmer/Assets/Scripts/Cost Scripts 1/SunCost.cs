using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunCost : MonoBehaviour {

    static public int SunTotal;
    public bool isPlaced;

    private void Start()
    {
        SunTotal = 0;
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
            SunTotal += 1;
            isPlaced = true;
        }
    }
}
