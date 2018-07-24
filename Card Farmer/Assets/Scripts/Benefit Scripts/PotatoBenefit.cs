using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotatoBenefit : MonoBehaviour {
	
    static public int potatoTotal;
    public bool isPlaced;

    private void Start()
    {
        potatoTotal = 0;
        isPlaced = false;
}

    void Update ()
    {
        SetCostTotal();
        Debug.Log(potatoTotal);
    }

    void SetCostTotal()
    {
        if (this.transform.parent.name == "Placement" && Input.GetMouseButtonUp(0) && isPlaced == false)
        {
            potatoTotal += 4;
            isPlaced = true;
        }
    }
}