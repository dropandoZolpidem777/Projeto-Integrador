using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IniciarOjogo : MonoBehaviour
{
    
    public string nomeCena = "SkyCity";
    string cenaAtual;
    private void Start()
    {
        cenaAtual = nomeCena;
    }

    public void ComeçarOJogo()
    {
        SceneManager.LoadScene(cenaAtual);
    }

}
