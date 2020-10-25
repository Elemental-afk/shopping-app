using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextKoszyka : MonoBehaviour
{
    public Text rozpiska;
    int y = 0;
    void Update()
    {
        rozpiska.text = "Produkty w koszyku:";
        for (int x = 0; x < 4; x++)
        {
            y = Produkty.hierarchy[x];
            if (Produkty.prod[y] > 0)
            {
                rozpiska.text += Environment.NewLine + Produkty.nazwa[y] + " x" + Produkty.prod[y] + " " + Produkty.xProduktu[y] + "zł";
            }
        }
        rozpiska.text += Environment.NewLine + "Całkowita wartość koszyka: " + Produkty.cartSum + "zł";
    }
}