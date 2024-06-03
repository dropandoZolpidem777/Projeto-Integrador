using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivarDoisObejctos : MonoBehaviour
{
   public GameObject menu2; 
   public GameObject menu;
    public int numero;
    public int numero2;

    private void Start()
    {
        menu.SetActive(false);
        numero = 1;
        numero2 = 1;
    }
    public void CliqueDeBotao1()
    {
        if (numero == 1)
        {
            menu.SetActive(true);
            numero = numero + 1;
        } else if (numero == 2)
        {
            menu.SetActive(false);
            numero = 1;
        }
    }

    public void CliqueDeBotao2()
    {
        if (numero2 == 1)
        {
            menu2.SetActive(true);
            numero2 = numero2 + 1;
        } else if (numero2 == 2)
        {
            menu2.SetActive(false);
            numero2 = 1;
        }
    }
}
