using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlayerAttack : MonoBehaviour
{
    Animator animator;

    Transform player;
    private Vector3 position;
    private float width;
    private float height;

    void Awake()
    {
        width = (float)Screen.width / 2.0f;
        height = (float)Screen.height / 2.0f;

        // Position used for the cube.
        position = new Vector3(0.0f, 0.0f, 0.0f);
    }


    // Start is called before the first frame update
    void Start()
    {
        //Attack();
        player = GameObject.FindWithTag("Player").transform;
        animator = player.GetComponent<Animator>();

       
    }

    // Update is called once per frame
    void Update()
    {

       // Attack();

        /*   if (Input.touchCount > 0)
           {
               transform.Find("espada").GetComponent<SpriteRenderer>().enabled = true;
               animator.SetTrigger("Ataque");
               FimEspadada();
           }*/
    }

  /*  public void AutoAttack()
    {
        transform.Find("espada").GetComponent<SpriteRenderer>().enabled = true;
        animator.SetTrigger("Ataque");
        Invoke("AutoAttack", 1.5f);
    }*/

    public void Attack()
    {
        if (Input.touchCount > 0)
        {
            Debug.Log("atacou");
            player.Find("espada").GetComponent<SpriteRenderer>().enabled = true;
            animator.SetTrigger("Ataque");
            //FimEspadada();
        }
    }

    public void FimEspadada()
    {
        player.Find("espada").GetComponent<SpriteRenderer>().enabled = false;
    }

}

