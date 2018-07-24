using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyCost : MonoBehaviour {

    static public int FlyTotal;
    public bool isPlaced;

    private void Start()
    {
        FlyTotal = 0;
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
            FlyTotal += 1;
            isPlaced = true;
        }
    }
}
