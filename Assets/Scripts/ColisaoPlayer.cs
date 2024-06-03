using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<<< HEAD:Assets/Scripts/carregarCena.cs
public class carregarCena : MonoBehaviour
{

    public GameObject carregar;
========
public class ColisaoPlayer : MonoBehaviour
{
    public GameObject Parede;
    public GameObject Player;
>>>>>>>> Enrico:Assets/Scripts/ColisaoPlayer.cs
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

<<<<<<<< HEAD:Assets/Scripts/carregarCena.cs
    private void OnTriggerEnter2D(Collider2D collision)
    {
        carregar.SetActive(true);
    }
========

>>>>>>>> Enrico:Assets/Scripts/ColisaoPlayer.cs

}
