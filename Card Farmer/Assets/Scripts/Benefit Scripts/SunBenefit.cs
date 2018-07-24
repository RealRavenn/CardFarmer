using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunBenefit : MonoBehaviour {

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
        Debug.Log(SunTotal);
    }

    void SetCostTotal()
    {
        if (this.transform.parent.name == "Placement" && Input.GetMouseButtonUp(0) && isPlaced == false)
        {
            SunTotal += 2;
            isPlaced = true;
        }
    }
}
