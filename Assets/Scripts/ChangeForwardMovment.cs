/*----------------------------------------
File Name: ChangeForwardMovement.cs
Purpose: Connects to animator and 
changes it's speed value
Author: Tarn Cooper
Modified: 25 April 2020
------------------------------------------
Copyright 2020 Tarn Cooper.
-----------------------------------*/
using UnityEngine;

//Class of changing forward movment
public class ChangeForwardMovment : MonoBehaviour
{
    Animator anim;
    //-----------------------------------------------------------
    // Connects to animator
    //-----------------------------------------------------------
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    //-----------------------------------------------------------
    // Changes speed in animator
    // strength (float): What is speed of animation?
    //-----------------------------------------------------------
    public void ChangeSpeed(float inSpeed)
    {
        anim.SetFloat("Speed", inSpeed);
    }
}
