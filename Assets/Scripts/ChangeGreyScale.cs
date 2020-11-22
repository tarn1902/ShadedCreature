/*----------------------------------------
File Name: ChangeGrayScale.cs
Purpose: Connects to post-processing and 
changes it's scale
Author: Tarn Cooper
Modified: 25 April 2020
------------------------------------------
Copyright 2020 Tarn Cooper.
-----------------------------------*/
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
//Class of changing grey scale
public class ChangeGreyScale : MonoBehaviour
{
    PostProcessVolume volume;
    GrayScale grayScale;
    //-----------------------------------------------------------
    // Connects to post-pocessing volume
    //-----------------------------------------------------------
    void Start()
    {
        volume = GetComponent<PostProcessVolume>();
        volume.profile.TryGetSettings(out grayScale);
    }
    //-----------------------------------------------------------
    // Changes scale for post-processing volume grey shader
    // scale (float): What is new scale of post-processing volume?
    //-----------------------------------------------------------
    public void ChangeGrayScale(float scale)
    {
        grayScale.blend.value = scale;
    }
}
