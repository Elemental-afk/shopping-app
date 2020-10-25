using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void Menu()
    {
        if(SceneManager.GetActiveScene().buildIndex != 0)
        {
            SceneManager.LoadScene("Menu");           
        }
        
    }        
    public void Account()
    {
        if (SceneManager.GetActiveScene().buildIndex != 1)
        {
            SceneManager.LoadScene("Settings");
        }
    }
    public void ShoppingCart()
    {
        if (SceneManager.GetActiveScene().buildIndex != 2)
        {
            SceneManager.LoadScene("Shopping cart 1");
        }
    }
        public void Searching()
    {

    }
    public void Kanapka()
    {
        Produkty.prod[0] += 1;
        Produkty.Sum();
        for (int x = 0; x < 4; x++)
        {
            if (Produkty.hierarchy[x] == 4 && Produkty.was[0] == false)
            {
                Produkty.hierarchy[x] = 0;
                Produkty.was[0] = true;
                break;
            }
        }
    }
    public void KanapkaXl()
    {
        Produkty.prod[1] += 1;
        Produkty.Sum();
        for (int x = 0; x < 4; x++)
        {
            if (Produkty.hierarchy[x] == 4 && Produkty.was[1] == false)
            {
                Produkty.hierarchy[x] = 1;
                Produkty.was[1] = true;
                break;
            }
        }
    }
    public void Batonik()
    {
        Produkty.prod[2] += 1;
        Produkty.Sum();
        for (int x = 0; x < 4; x++)
        {
            if (Produkty.hierarchy[x] == 4 && Produkty.was[2] == false)
            {
                Produkty.hierarchy[x] = 2;
                Produkty.was[2] = true;
                break;
            }
        }
    }
    public void Tymbark()
    {
        Produkty.prod[3] += 1;
        Produkty.Sum();
        for (int x = 0; x < 4; x++)
        {
            if (Produkty.hierarchy[x] == 4 && Produkty.was[3] == false)
            {
                Produkty.hierarchy[x] = 3;
                Produkty.was[3] = true;
                break;
            }
        }
    }
}
