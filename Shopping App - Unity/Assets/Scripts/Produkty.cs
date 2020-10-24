using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Produkty : MonoBehaviour
{
    //float kanapka = 5f;
    //float kanapkaXl = 6.5f;
    public static float cartSum = 0f;
    public static float[] prod = {0f, 0f, 0f, 0f,};
    static float[] cena = { 5f, 6.5f, 1.7f, 3f,};
    public static float[] xProduktu = { 0f, 0f, 0f, 0f,};
    public static string[] nazwa = {"Kanapka", "KanapkaXL", "Batonik", "Tymbark",};
    public static void Sum()
    {
        cartSum = 0f;
        for (int x = 0; x < 4; x++)
        {
            xProduktu[x] = prod[x] * cena[x];
            cartSum += xProduktu[x];
            //cartSum = prod[0] * cena[0] + prod[1] * cena[1];
            //xProduktu[0] = prod[0] * cena[0];
            //xProduktu[1] = prod[1] * cena[1];
            //Debug.Log(prod[x]);
        }
        Debug.Log(cartSum);
        
    }
}
