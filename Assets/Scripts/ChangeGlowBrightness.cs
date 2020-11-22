/*----------------------------------------
File Name: ChangeGlowBrightness.cs
Purpose: Connects to mesh renderer and 
changes it's shader strength value
Author: Tarn Cooper
Modified: 25 April 2020
------------------------------------------
Copyright 2020 Tarn Cooper.
-----------------------------------*/
using UnityEngine;
//Class of changing glow brightness
public class ChangeGlowBrightness : MonoBehaviour
{
    Material mat;
    //-----------------------------------------------------------
    // Connects to mesh renderer
    //-----------------------------------------------------------
    void Start()
    {
        mat = GetComponent<SkinnedMeshRenderer>().material;
    }

    //-----------------------------------------------------------
    // Changes rim strength of shader
    // strength (float): What is strength of shader?
    //-----------------------------------------------------------
    public void ChangeRimStrength(float strength)
    {
        mat.SetFloat(Shader.PropertyToID("_RimStrength"), strength);
    }
}
