using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivarObejcto : MonoBehaviour
{
    public GameObject menu;
    public int numero;

    private void Start()
    {
        menu.SetActive(false);
        numero = 1;
    }
    public void CliqueDeBotao()
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
}   
