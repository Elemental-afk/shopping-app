using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class TextKoszyka : MonoBehaviour
{
    public Text rozpiska;
    void Update()
    {
        rozpiska.text = "Produkty w koszyku:";
        if (Produkty.prod[0] > 0)
        {
            rozpiska.text += Environment.NewLine + "Kanapka x" + Produkty.prod[0] + " " + Produkty.xProduktu[0] + "zł";
        }
        if (Produkty.prod[1] > 0)
        {
            rozpiska.text += Environment.NewLine + "KanapkaXL x" + Produkty.prod[0] + " " + Produkty.xProduktu[1] + "zł";
        }
    }
}