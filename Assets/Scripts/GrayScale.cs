/*----------------------------------------
File Name: GrayScalePostProcess.cs
Purpose: Creates post process renderer and
effect settings
Author: Tarn Cooper
Modified: 26 April 2020
------------------------------------------
Copyright 2020 Tarn Cooper.
-----------------------------------*/
using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
//Class that inherited from Post process effect settings class
[Serializable]
[PostProcess(typeof(GrayScaleRenderer), PostProcessEvent.AfterStack, "Custom/GrayScale")]
public sealed class GrayScale : PostProcessEffectSettings
{
    [Range(0f, 1f), Tooltip("Gray scale effect intensity.")]
    public FloatParameter blend = new FloatParameter { value = 0.5f };
}
//Class that inherited from Post process effect renderer class
public sealed class GrayScaleRenderer : PostProcessEffectRenderer<GrayScale>
{
    //-----------------------------------------------------------
    // Overides function of render
    // context (PostProcessRenderContext): What is the context?
    //-----------------------------------------------------------
    public override void Render(PostProcessRenderContext context)
    {
        var sheet = context.propertySheets.Get(Shader.Find("Hidden/Custom/GrayScale"));
        sheet.properties.SetFloat("_Blend", settings.blend);
        context.command.BlitFullscreenTriangle(context.source, context.destination, sheet, 0);
    }
}
