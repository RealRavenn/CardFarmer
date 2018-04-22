using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CostTotal : MonoBehaviour {

    public Text costTotal;
    public int startingTotal = 0;

	void Start () {
        costTotal.text = startingTotal.ToString();
	}
	
}
