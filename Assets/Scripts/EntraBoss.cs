using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntraBoss : MonoBehaviour
{
    public int entrou;
    public string nomeDaCenaBoss;
    public GameObject inconePararecer;


    void Start()
    {
        entrou = 0;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        entrou = 1;
        inconePararecer.SetActive(true);
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        inconePararecer.SetActive(false);
    }

    public void Inteiracao()
    {
        if (entrou == 1)
        {
            SceneManager.LoadScene(nomeDaCenaBoss);
        }
    }
}
