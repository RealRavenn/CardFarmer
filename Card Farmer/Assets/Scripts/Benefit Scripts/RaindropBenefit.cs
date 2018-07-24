using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaindropBenefit : MonoBehaviour {

    static public int RaindropTotal;
    public bool isPlaced;

    private void Start()
    {
        RaindropTotal = 0;
        isPlaced = false;
    }

    void Update()
    {
        SetCostTotal();
        Debug.Log(RaindropTotal);
    }

    void SetCostTotal()
    {
        if (this.transform.parent.name == "Placement" && Input.GetMouseButtonUp(0) && isPlaced == false)
        {
            RaindropTotal += 2;
            isPlaced = true;
        }
    }
}
