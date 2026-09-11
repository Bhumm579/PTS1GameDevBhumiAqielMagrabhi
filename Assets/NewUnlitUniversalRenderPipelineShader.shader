Shader "Custom/NewUnlitUniversalRenderPipelineShader"
{
    Properties
    {
        [MainColor] _BaseColor("Base Color", Color) = (130, 182, 71, 1)
    }

    SubShader
    {
        Tags { 
                "RenderType" = "Transparent" 
                "RenderPipeline" = "UniversalPipeline" 
                "Queue" = "Transparent" 
                "IgnoreProjector" = "True"}

        Pass
        {
            Name "Unlit2D"
            Tags {"LightMode" = "Universal2D"}

            HLSLPROGRAM

            #pragma vertex vert
            #pragma fragment frag

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            
            CBUFFER_START(UnityPerMaterial)
                float4 _BaseColor;
            CBUFFER_END

            struct Attributes
            {
                float4 objectPosition : POSITION;
            };

            struct keFragment
            {
                float4 clipPosition : SV_POSITION;
            };

            keFragment vert(Attributes IN)
            {
                keFragment OUT;
                OUT.clipPosition = TransformObjectToHClip(IN.objectPosition.xyz);
                return OUT;
            }

            half4 frag(keFragment IN) : SV_Target
            {
                return (half4)_BaseColor;
            }
            ENDHLSL
        }
    }
}
