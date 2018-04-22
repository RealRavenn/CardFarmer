using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotatoScore : MonoBehaviour {
	
    public int costAdding = 4;
    public int potatoCostTotal = 0;
    public bool isTrue;

    void Update () {

        Debug.Log(potatoCostTotal);
    }

    void SetCostTotal()
    {
        if (this.transform.parent.name == "Placement")
        {
            potatoCostTotal += costAdding;
        }
    }
}
