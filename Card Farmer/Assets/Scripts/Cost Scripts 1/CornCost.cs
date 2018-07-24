using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornCost : MonoBehaviour {

    static public int CornTotal;
    public bool isPlaced;

    private void Start()
    {
        CornTotal = 0;
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
            CornTotal += 3;
            isPlaced = true;
        }
    }
}
