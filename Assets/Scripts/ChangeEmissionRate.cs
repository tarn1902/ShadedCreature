/*----------------------------------------
File Name: ChangeEmissionRate.cs
Purpose: Connects to particle system and 
changes it's emission rate
Author: Tarn Cooper
Modified: 25 April 2020
------------------------------------------
Copyright 2020 Tarn Cooper.
-----------------------------------*/
using UnityEngine;
//Class for changing emission rate
public class ChangeEmissionRate : MonoBehaviour
{
    ParticleSystem particles;
    //-----------------------------------------------------------
    // Connects to particle system
    //-----------------------------------------------------------
    void Start()
    {
        particles = GetComponent<ParticleSystem>();
    }

    //-----------------------------------------------------------
    // Changes emission rate of particle system
    // rate (float): What is new rate of particle system?
    //-----------------------------------------------------------
    public void ChangeEmission(float rate)
    {
        var emission = particles.emission;
        emission.rateOverTime = rate;
    }
}
