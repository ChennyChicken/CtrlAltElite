﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    [Header("Layers")]
    public LayerMask groundLayer;
    public LayerMask wallLayer;
    public LayerMask platformLayer;
    public LayerMask waterLayer;

    [Header("Checks")]
    [SerializeField] private Transform groundCheck;
    [SerializeField] private Transform wallCheck;
    [SerializeField] private Transform wallCheck2;
    [SerializeField] private Transform wallCheck3;
    [SerializeField] private Transform ledgeCheck;

    public bool onGround;
    public bool onPlatform;
    public bool onWall;
    public bool inWater;
    public bool canLedge;

    [Space]
    [Header("Collision")]
    public float collisionRadius;

    // Update is called once per frame
    void Update()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position, collisionRadius, groundLayer);
        onPlatform = Physics2D.OverlapCircle(groundCheck.position, collisionRadius, platformLayer);

        onWall = Physics2D.OverlapCircle(wallCheck.position, collisionRadius, wallLayer)
            || Physics2D.OverlapCircle(wallCheck2.position, collisionRadius, wallLayer)
            || Physics2D.OverlapCircle(wallCheck3.position, collisionRadius, wallLayer);

        canLedge = Physics2D.OverlapCircle(ledgeCheck.position, collisionRadius, groundLayer);

        inWater = Physics2D.OverlapCircle(groundCheck.position, collisionRadius, waterLayer);
    }
}
