using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BenefitTotal : MonoBehaviour {

    public static int total;
    public Text benefitText;

    void Start()
    {

    }

    void Update()
    {
        total = PotatoBenefit.potatoTotal + BeeBenefit.BeeTotal + CornBenefit.CornTotal + FlyBenefit.FlyTotal + RaindropBenefit.RaindropTotal + SickleBenefit.SickleTotal + SunBenefit.SunTotal;
        Debug.Log(total);

        benefitText.text = total.ToString();
    }
}
