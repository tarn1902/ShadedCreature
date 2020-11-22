/*----------------------------------------
File Name: RimExtented.shader
Purpose: Gives mesh a outline
Author: Tarn Cooper
Modified: 26 April 2020
------------------------------------------
Copyright 2020 Tarn Cooper.
-----------------------------------*/
Shader "Custom/RimExtented"
{
	//Public varaibles for unity
    Properties
    {
        _MainTex ("Diffuse (RGB)", 2D) = "white" {}
		_NormalMap("Normal Map", 2d) = "bump" {}
		_RimColor ("Rim Color", Color) = (1.0, 1.0, 1.0, 0.0)
		_RimStrength("Rim Strength", Range(1.0, 4.0)) = 1.45
	}
		SubShader
	{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		CGPROGRAM
		#pragma surface surf Lambert

		sampler2D _MainTex;
		sampler2D _NormalMap;
		float4 _RimColor;
		float _RimConcentration;
		float _RimStrength;
		
		//Accesses certain imputs of mesh
        struct Input
        {
            float2 uv_MainTex;
			float2 uv_NormalMap;
			float3 viewDir;
        };

		//Effects surface shader of mesh
        void surf (Input IN, inout SurfaceOutput o)
        {
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex);
			float Lc = saturate(dot(normalize(IN.viewDir), o.Normal));
			half rim = 1.0f - Lc;
            o.Albedo = c.rgb;
			o.Normal = UnpackNormal(tex2D(_NormalMap, IN.uv_NormalMap));
            o.Alpha = c.a;
			o.Emission = _RimStrength * (_RimColor.rgb * smoothstep(0.2, 0.6, rim));
        }
        ENDCG
    }
    FallBack "Diffuse"
}
