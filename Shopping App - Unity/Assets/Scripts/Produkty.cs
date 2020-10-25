using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Produkty : MonoBehaviour
{
    public static float cartSum = 0f;
    public static float[] prod = {0f, 0f, 0f, 0f, 0f,};
    static float[] cena = { 5f, 6.5f, 1.7f, 3f, 0f,};
    public static float[] xProduktu = { 0f, 0f, 0f, 0f, 0f,};
    public static string[] nazwa = {"Kanapka", "KanapkaXL", "Batonik", "Woda", "",};
    public static int[] hierarchy = {4, 4, 4, 4,};
    public static bool[] was = { false, false, false, false, };
    public static void Sum()
    {
        cartSum = 0f;
        for (int x = 0; x < 4; x++)
        {
            xProduktu[x] = prod[x] * cena[x];
            cartSum += xProduktu[x];
        }
        //Debug.Log(cartSum);       
    }
}
