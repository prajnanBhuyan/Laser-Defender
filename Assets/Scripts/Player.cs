﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 10f;

    [SerializeField]
    float padding = 0.75f;

    [SerializeField]

    

    float xMin, xMax, yMin, yMax;


    // Start is called before the first frame update
    void Start()
    {
        SetUpMoveBoundaries();
    }

    private void SetUpMoveBoundaries()
    {
        var gameCamera = Camera.main;

        var min = gameCamera.ViewportToWorldPoint(new Vector3(0f, 0f, 0f));
        var max = gameCamera.ViewportToWorldPoint(new Vector3(1f, 1f, 0f));

        xMin = min.x + padding;
        yMin = min.y + padding;
        xMax = max.x - padding;
        yMax = max.y - padding;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        var deltaY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        var newXPos = Mathf.Clamp(transform.position.x + deltaX, xMin, xMax);
        var newYPos = Mathf.Clamp(transform.position.y + deltaY, yMin, yMax);

        transform.position = new Vector2(newXPos, newYPos);
    }
}
