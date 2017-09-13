﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmouryBox : MonoBehaviour
{

    public Text countText;
    private int count;
    private bool x;

    // Use this for initialization
    void Start()
    {
        count = 5;
        SetCountText();
    }

    void Awake()
    {
        SetCountText();
    }
    // Update is called once per frame
    void Update()
    {
        count = Convert.ToInt32(countText.text);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            count += 5;
            SetCountText();

        }
    }

    /*void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("bullet"))
        {
            
            Destroy(gameObject);
        }

    }*/

    void SetCountText()
    {
        countText.text = count.ToString();
    }
    
}
