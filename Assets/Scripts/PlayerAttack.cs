using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        AutoAttack();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            transform.Find("espada").GetComponent<SpriteRenderer>().enabled = true;
            animator.SetTrigger("Ataque");
        }
        
    }

    public void AutoAttack()
    {
        transform.Find("espada").GetComponent<SpriteRenderer>().enabled = true;
        animator.SetTrigger("Ataque");
        Invoke("AutoAttack", 1.5f);
    }

    public void FimEspadada()
    {
        transform.Find("espada").GetComponent<SpriteRenderer>().enabled = false;
    }

}

