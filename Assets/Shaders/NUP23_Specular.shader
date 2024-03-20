Shader "Custom/NUP24_Specular"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Smoothness ("Smoothness", Range(0,1)) = 0.0
        _Metallic ("Metallic", Range(0,1)) = 0.0
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows
        #pragma target 3.0

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        half _Smoothness;
        fixed4 _Color;
        half _Metallic;


        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color;
            o.Albedo = c.rgb;
            //o.Alpha = c.a;

            o.Smoothness = _Smoothness;

            //https://docs.unity3d.com/Manual/SL-SurfaceShaders.html
            o.Metallic = _Metallic;
            //o.Emission = color;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
