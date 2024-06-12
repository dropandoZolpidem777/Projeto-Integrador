using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaSeguirPlayer : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        // player = GameObject.Find("Protagonista").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
    }
}
