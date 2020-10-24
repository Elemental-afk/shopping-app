using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Produkty : MonoBehaviour
{
    //float kanapka = 5f;
    //float kanapkaXl = 6.5f;
    public static float cartSum = 0f;
    float kan = 0f;
    float kanXl = 0f;
    public static int[] prod = {0, 0,};
    static float[] cena = { 5f, 6.5f, };
    static string[] nazwa = {"kanapka","kanapkaXL",};
    public static float[] xProduktu = { 0, 0, };

    public static void Sum()
    {
        cartSum = prod[0] * cena[0] + prod[1] * cena[1];
        xProduktu[0] = prod[0] * cena[0];
        xProduktu[1] = prod[1] * cena[1];
        Debug.Log(cartSum);
    }
}
