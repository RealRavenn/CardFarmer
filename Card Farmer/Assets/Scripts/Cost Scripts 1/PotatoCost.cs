using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoCost : MonoBehaviour {

    static public int PotatoTotal;
    public bool isPlaced;

    private void Start()
    {
        PotatoTotal = 0;
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
            PotatoTotal += 4;
            isPlaced = true;
        }
    }
}
