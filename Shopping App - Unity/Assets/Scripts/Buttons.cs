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
    public void ShoppingCart()
    {
        if (SceneManager.GetActiveScene().buildIndex != 1)
        {
            SceneManager.LoadScene("Shopping cart 1");
        }
        
    }
    public void Account()
    {
        if (SceneManager.GetActiveScene().buildIndex != 2)
        {
            SceneManager.LoadScene("Settings");
        }
    }
    public void Searching()
    {

    }
    public void Kanapka()
    {
        Produkty.prod[0] += 1;
        //Mathf.Clamp(Produkty.prod[0], 0, 10);
        Produkty.Sum();
        //Debug.Log(Produkty.prod[0]);
    }
    public void KanapkaXl()
    {
        Produkty.prod[1] += 1;
        //Mathf.Clamp(Produkty.prod[1], 0, 10);
        Produkty.Sum();
        //Debug.Log(Produkty.prod[1]);
    } 
}
