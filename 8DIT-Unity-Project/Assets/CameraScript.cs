﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player;

    // Start is called before the first frame update
    void Start()

    {
 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(player.position.x, player.position.y + 3f);
    }
}
