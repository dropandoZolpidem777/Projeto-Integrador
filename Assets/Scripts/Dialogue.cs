
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Dialogue : MonoBehaviour
{
    public GameObject botaoDeIcone;
    // Vari?vel para controlar se o jogador est? dentro do alcance da placa
    public int jogadorPerto = 0;

    // Tecla para interagir
    public KeyCode teclaDeInteracao = KeyCode.E;

    [Header("Components")]
    public GameObject dialogueObj;
    public Image profile;
    public TextMeshProUGUI speechText;
    public TextMeshProUGUI actorNameText;

    [Header("Settings")]
    public float typingSpeed;
    string[] sentence;
    int index;

    private void Start()
    {
        botaoDeIcone.SetActive(false);
        //se clicar E vai abrir o dialogo
        teclaDeInteracao = KeyCode.Z;
    }

    public void Speech(Sprite p, string[] text, string actorName)
    {
        dialogueObj.SetActive(true);
        profile.sprite = p;
        sentence = text;
        actorNameText.text = actorName;
        StartCoroutine(TypeSentence());
    }

    IEnumerator TypeSentence()
    {
        foreach (char letter in sentence[index].ToCharArray())
        {
            speechText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        if (speechText.text == sentence[index])
        {
            //ainda h? texto
            if (index < sentence.Length - 1)
            {
                index++;
                speechText.text = "";
                StartCoroutine(TypeSentence());
            }
            else // lido quando acaba os textos
            {
                speechText.text = "";
                index = 0;
                dialogueObj.SetActive(false);
            }
        }
    }
}

