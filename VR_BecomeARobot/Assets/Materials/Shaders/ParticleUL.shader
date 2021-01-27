Shader "Unlit/ParticleUL"
{
    Properties
    {
		_Color ("Color", Color) = (1, 1, 1, 1)
		_ColorPersistent ("Color2", Color) = (0, 0, 0, 1)
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"
			#include "Lighting.cginc"
			#include "AutoLight.cginc"

            struct VertexInput
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
				float3 normal : NORMAL;
            };

            struct VertexOutput
            {
				float4 vertex : SV_POSITION;
                float2 uv : TEXCOORD0;
				float3 normal : TEXCOORD1;
				float3 worldPos : TEXCOORD2;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
			uniform float3 _VsPos0;
			uniform float3 _VsPos1;
			uniform float3 _VsPos2;
			uniform float3 _VsPos3;

			uniform float4 _Color;
			uniform float4 _ColorPersistent;
			float _range;

			VertexOutput vert (VertexInput v)
            {
				VertexOutput o;

				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				o.normal = v.normal;
				o.worldPos = mul( unity_ObjectToWorld, v.vertex);
				o.vertex = UnityObjectToClipPos(v.vertex);
                return o;
            }

            fixed4 frag (VertexOutput o) : SV_Target
            {
				// Lighting
				float3 lightDir = float3(1, 1, 1);
				float3 lightFalloff = max(0, dot(lightDir, o.normal));
				float3 ambientLight = float3(0.2, 0.2, 0.2);
				float3 light = lightFalloff + ambientLight;

				// VRRig Distance
				float dist0 = distance(_VsPos0, o.worldPos);
				float dist1 = distance(_VsPos1, o.worldPos);
				float dist2 = distance(_VsPos2, o.worldPos);
				float dist3 = distance(_VsPos3, o.worldPos);

				// Particle Visibility
				float backgroundColor = 0.6;
				// float visibleParticles = (saturate(1 - dist1) * light) + backgroundColor;
				float visibleParticles = saturate(1 - (dist0)) + saturate(1 - (dist1 - 0.5))
					+ saturate(1 - (dist2 - 1.25)) + saturate(1 - (dist3 - 1.6));

				float3 finalParticleColor = (visibleParticles * light * _Color) + backgroundColor + _ColorPersistent;


				return float4(finalParticleColor, 1);

            }
            ENDCG
        }
    }
}
