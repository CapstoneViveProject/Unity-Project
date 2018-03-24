﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ConsoleBehavior : MonoBehaviour
{
    int distanceEntered = 0;
    public Text Tens;
    public Text Ones;
    public GameObject controllerLeft;
    Menu menu;
    void Start ()
    {
        UpdateTotal();
        menu = controllerLeft.GetComponent<Menu>();
	}

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("MainCamera"))
        {
            menu.XRoomConsole = true;
        }
        
    }
    
    private void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("MainCamera"))
        {
            menu.XRoomConsole = false;
        }
    }
    private void OnTriggerStay(Collider collision)
    {
        if (collision.CompareTag("MainCamera"))
        {
            //Debug.Log("AHDJFLSDJFLKSDJFLKSJD");
        }
    }
    public void IncrementPress()
    {
        distanceEntered++;
        UpdateTotal();
    }
    public void DeincrementPress()
    {
        if(distanceEntered!=0)
        {
            distanceEntered--;
        }
        UpdateTotal();
    }
    public void SubmitPress()
    {
        //return distanceEntered;
    }
    void UpdateTotal()
    {
        char tens;
        char ones;
        string i = distanceEntered + "";
        if(i.Length==2)
        {
            tens = i[0];
            ones = i[1];
        }
        else
        {
            ones = i[0];
            tens = '0';
        }     

        Tens.text = tens.ToString(); 
        Ones.text = ones.ToString();
        
    }
}
