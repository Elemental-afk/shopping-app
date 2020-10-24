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
        for (int x = 0; x < 4; x++)
        {
            if (Produkty.prod[x] > 0)
            {
                rozpiska.text += Environment.NewLine + Produkty.nazwa[x] + " x" + Produkty.prod[x] + " " + Produkty.xProduktu[x] + "zł";
            }
        }
        rozpiska.text += Environment.NewLine + "Całkowita wartość koszyka: " + Produkty.cartSum + "zł";
        /*if (Produkty.prod[0] > 0)
        {
            rozpiska.text += Environment.NewLine + "Kanapka x" + Produkty.prod[0] + " " + Produkty.xProduktu[0] + "zł";
        }
        if (Produkty.prod[1] > 0)
        {
            rozpiska.text += Environment.NewLine + "KanapkaXL x" + Produkty.prod[1] + " " + Produkty.xProduktu[1] + "zł";
        }
        if (Produkty.prod[2] > 0)
        {
            rozpiska.text += Environment.NewLine + "Batonik x" + Produkty.prod[2] + " " + Produkty.xProduktu[2] + "zł";
        }
        if (Produkty.prod[3] > 0)
        {
            rozpiska.text += Environment.NewLine + "Tymbark x" + Produkty.prod[3] + " " + Produkty.xProduktu[3] + "zł";
        } */
    }
}