using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeBenefit : MonoBehaviour {

    static public int BeeTotal;
    public bool isPlaced;

    private void Start()
    {
        BeeTotal = 0;
        isPlaced = false;
    }

    void Update()
    {
        SetCostTotal();
        Debug.Log(BeeTotal);
    }

    void SetCostTotal()
    {
        if (this.transform.parent.name == "Placement" && Input.GetMouseButtonUp(0) && isPlaced == false)
        {
            BeeTotal += 3;
            isPlaced = true;
        }
    }
}
