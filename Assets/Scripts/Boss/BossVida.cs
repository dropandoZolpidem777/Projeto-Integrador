using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossVida : MonoBehaviour
{
    public Image lifebar;
    public Image redBar;

    int vidaMaximaDoBoss = 1;
    public static int vidaAtualDoBoss;

    private void Update()
    {
        vidaAtualDoBoss = vidaMaximaDoBoss;
    }


    public void MorteBoss()
    {

        vidaAtualDoBoss--;
        if (vidaAtualDoBoss <= 0)
        {
            Destroy(gameObject);
        }

        Vector3 lifeBarScale = lifebar.rectTransform.localScale;
        lifeBarScale.x = (float)vidaAtualDoBoss / vidaMaximaDoBoss;
        lifebar.rectTransform.localScale = lifeBarScale;
        StartCoroutine(ReddBar(lifeBarScale));

    }

    IEnumerator ReddBar(Vector3 newScale)
    {
        yield return new WaitForSeconds(0.5f);
        Vector3 redBarScale = redBar.transform.localScale;

        while (redBar.transform.localScale.x > newScale.x) 
        {
            redBarScale.x -= Time.deltaTime * 0.25f;
            redBar.transform.localScale = redBarScale;

            yield return null;
        }

        redBar.transform.localScale = newScale;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("sword"))
        {
            MorteBoss();
        }
    }

}