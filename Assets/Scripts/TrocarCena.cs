using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarCena : MonoBehaviour
{

    public GameObject ObjAparecer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ObjAparecer.SetActive(true);
        }
    }
    public void trocarDeParaBoss()
    {
        SceneManager.LoadScene("BossFighter");
    }
    public void trocarDeFimDOGAME()
    {
        SceneManager.LoadScene("JogoCenaFinal");
    }
    public void trocarDeTowerFighter()
    {
        SceneManager.LoadScene("Towefight");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ObjAparecer.SetActive(false);

        }
    }
}
