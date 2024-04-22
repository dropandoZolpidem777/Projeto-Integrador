using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    public Vector2 camera;
    public Vector2 player;

    float direcaoXPlayer;
    float direcaoYPlayer;

    float direcaoXCamera;
    float direcaoYCamera;

    void Start()
    {
        player = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        player = new Vector2(direcaoXPlayer, direcaoYPlayer);
        camera = new Vector2(direcaoXCamera, direcaoYCamera);

        if (player == player)
        {
            camera = player;
        }
    }
}
