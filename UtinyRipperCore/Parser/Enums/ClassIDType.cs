﻿using System;

namespace UtinyRipper
{
	public enum ClassIDType
	{
		Object					= 0,

		GameObject				= 1,
		Component				= 2,
		LevelGameManager		= 3,
		Transform				= 4,
		TimeManager				= 5,
		GlobalGameManager		= 6,
		Behaviour				= 8,
		GameManager				= 9,
		AudioManager			= 11,
		ParticleAnimator		= 12,
		InputManager			= 13,
		EllipsoidParticleEmitter = 15,
		Pipeline				= 17,
		EditorExtension			= 18,
		Physics2DSettings		= 19,
		Camera					= 20,
		Material				= 21,
		MeshRenderer			= 23,
		Renderer				= 25,
		ParticleRenderer		= 26,
		Texture					= 27,
		Texture2D				= 28,
		SceneSettings			= 29,
		GraphicsSettings		= 30,
		PipelineManager			= 31,
		MeshFilter				= 33,
		OcclusionPortal			= 41,
		Mesh					= 43,
		Skybox					= 45,
		QualitySettings			= 47,
		Shader					= 48,
		TextAsset				= 49,
		Rigidbody2D				= 50,
		Physics2DManager		= 51,
		Collider2D				= 53,
		Rigidbody				= 54,
		PhysicsManager			= 55,
		Collider				= 56,
		Joint					= 57,
		CircleCollider2D		= 58,
		HingeJoint				= 59,
		PolygonCollider2D		= 60,
		BoxCollider2D			= 61,
		PhysicsMaterial2D		= 62,
		MeshCollider			= 64,
		BoxCollider				= 65,
		SpriteCollider2D		= 66,
		EdgeCollider2D			= 68,
		CapsuleCollider2D		= 70,
		ComputeShader			= 72,
		AnimationClip			= 74,
		ConstantForce			= 75,
		WorldParticleCollider	= 76,
		TagManager				= 78,
		AudioListener			= 81,
		AudioSource				= 82,
		AudioClip				= 83,
		RenderTexture			= 84,
		CustomRenderTexture		= 86,
		MeshParticleEmitter		= 87,
		ParticleEmitter			= 88,
		Cubemap					= 89,
		Avatar					= 90,
		AnimatorController		= 91,
		GUILayer				= 92,
		RuntimeAnimatorController = 93,
		ScriptMapper			= 94,
		Animator				= 95,
		TrailRenderer			= 96,
		DelayedCallManager		= 98,
		TextMesh				= 102,
		RenderSettings			= 104,
		Light					= 108,
		CGProgram				= 109,
		BaseAnimationTrack		= 110,
		Animation				= 111,
		MonoBehaviour			= 114,
		MonoScript				= 115,
		MonoManager				= 116,
		Texture3D				= 117,
		NewAnimationTrack		= 118,
		Projector				= 119,
		LineRenderer			= 120,
		Flare					= 121,
		Halo					= 122,
		LensFlare				= 123,
		FlareLayer				= 124,
		HaloLayer				= 125,
		NavMeshAreas			= 126,
		HaloManager				= 127,
		Font					= 128,
		PlayerSettings			= 129,
		NamedObject				= 130,
		GUITexture				= 131,
		GUIText					= 132,
		GUIElement				= 133,
		PhysicMaterial			= 134,
		SphereCollider			= 135,
		CapsuleCollider			= 136,
		SkinnedMeshRenderer		= 137,
		FixedJoint				= 138,
		RaycastCollider			= 140,
		BuildSettings			= 141,
		AssetBundle				= 142,
		CharacterController		= 143,
		CharacterJoint			= 144,
		SpringJoint				= 145,
		WheelCollider			= 146,
		ResourceManager			= 147,
		NetworkView				= 148,
		NetworkManager			= 149,
		PreloadData				= 150,
		MovieTexture			= 152,
		ConfigurableJoint		= 153,
		TerrainCollider			= 154,
		MasterServerInterface	= 155,
		TerrainData				= 156,
		LightmapSettings		= 157,
		WebCamTexture			= 158,
		EditorSettings			= 159,
		InteractiveCloth		= 160,
		ClothRenderer			= 161,
		EditorUserSettings		= 162,
		SkinnedCloth			= 163,
		AudioReverbFilter		= 164,
		AudioHighPassFilter		= 165,
		AudioChorusFilter		= 166,
		AudioReverbZone			= 167,
		AudioEchoFilter			= 168,
		AudioLowPassFilter		= 169,
		AudioDistortionFilter	= 170,
		SparseTexture			= 171,
		AudioBehaviour			= 180,
		AudioFilter				= 181,
		WindZone				= 182,
		Cloth					= 183,
		SubstanceArchive		= 184,
		ProceduralMaterial		= 185,
		ProceduralTexture		= 186,
		Texture2DArray			= 187,
		CubemapArray			= 188,
		OffMeshLink				= 191,
		OcclusionArea			= 192,
		Tree					= 193,
		NavMeshObsolete			= 194,
		NavMeshAgent			= 195,
		NavMeshSettings			= 196,
		LightProbesLegacy		= 197,
		ParticleSystem			= 198,
		ParticleSystemRenderer	= 199,
		ShaderVariantCollection	= 200,
		LODGroup				= 205,
		BlendTree				= 206,
		Motion					= 207,
		NavMeshObstacle			= 208,
		TerrainInstance			= 210,
		SpriteRenderer			= 212,
		Sprite					= 213,
		CachedSpriteAtlas		= 214,
		ReflectionProbe			= 215,
		ReflectionProbes		= 216,
		Terrain					= 218,
		LightProbeGroup			= 220,
		AnimatorOverrideController = 221,
		CanvasRenderer			= 222,
		Canvas					= 223,
		RectTransform			= 224,
		CanvasGroup				= 225,
		BillboardAsset			= 226,
		BillboardRenderer		= 227,
		SpeedTreeWindAsset		= 228,
		AnchoredJoint2D			= 229,
		Joint2D					= 230,
		SpringJoint2D			= 231,
		DistanceJoint2D			= 232,
		HingeJoint2D			= 233,
		SliderJoint2D			= 234,
		WheelJoint2D			= 235,
		ClusterInputManager		= 236,
		BaseVideoTexture		= 237,
		NavMeshData				= 238,
		AudioMixer				= 240,
		AudioMixerController	= 241,
		AudioMixerGroupController = 243,
		AudioMixerEffectController = 244,
		AudioMixerSnapshotController = 245,
		PhysicsUpdateBehaviour2D = 246,
		ConstantForce2D			= 247,
		Effector2D				= 248,
		AreaEffector2D			= 249,
		PointEffector2D			= 250,
		PlatformEffector2D		= 251,
		SurfaceEffector2D		= 252,
		BuoyancyEffector2D		= 253,
		RelativeJoint2D			= 254,
		FixedJoint2D			= 255,
		FrictionJoint2D			= 256,
		TargetJoint2D			= 257,
		LightProbes				= 258,
		LightProbeProxyVolume	= 259,
		SampleClip				= 271,
		AudioMixerSnapshot		= 272,
		AudioMixerGroup			= 273,
		NScreenBridge			= 280,
		AssetBundleManifest		= 290,
		UnityAdsManager			= 292,
		RuntimeInitializeOnLoadManager = 300,
		CloudWebServicesManager	= 301,
		UnityAnalyticsManager	= 303,
		CrashReportManager		= 304,
		PerformanceReportingManager = 305,
		UnityConnectSettings	= 310,
		AvatarMask1				= 319,
		VideoPlayer				= 328,
		VideoClip				= 329,
		OcclusionCullingData	= 363,
		Prefab					= 1001,
		EditorExtensionImpl		= 1002,
		AssetImporter			= 1003,
		AssetDatabase			= 1004,
		Mesh3DSImporter			= 1005,
		TextureImporter			= 1006,
		ShaderImporter			= 1007,
		ComputeShaderImporter	= 1008,
		AvatarMask				= 1011,
		AudioImporter			= 1020,
		HierarchyState			= 1026,
		GUIDSerializer			= 1027,
		AssetMetaData			= 1028,
		DefaultAsset			= 1029,
		DefaultImporter			= 1030,
		TextScriptImporter		= 1031,
		SceneAsset				= 1032,
		NativeFormatImporter	= 1034,
		MonoImporter			= 1035,
		AssetServerCache		= 1037,
		LibraryAssetImporter	= 1038,
		ModelImporter			= 1040,
		FBXImporter				= 1041,
		TrueTypeFontImporter	= 1042,
		MovieImporter			= 1044,
		EditorBuildSettings		= 1045,
		DDSImporter				= 1046,
		InspectorExpandedState	= 1048,
		AnnotationManager		= 1049,
		PluginImporter			= 1050,
		EditorUserBuildSettings	= 1051,
		PVRImporter				= 1052,
		ASTCImporter			= 1053,
		KTXImporter				= 1054,
		AnimatorStateTransition	= 1101,
		AnimatorState			= 1102,
		HumanTemplate			= 1105,
		AnimatorStateMachine	= 1107,
		PreviewAssetType		= 1108,
		AnimatorTransition		= 1109,
		SpeedTreeImporter		= 1110,
		AnimatorTransitionBase	= 1111,
		SubstanceImporter		= 1112,
		LightmapParameters		= 1113,
		LightmapSnapshot		= 1120,

		SubDerived				= 367388927,
		SiblingDerived			= 334799969,
		SpriteAtlas				= 687078895,
		Derived					= 1091556383,
		LowerResBlitTexture		= 1480428607,
		RenderPassAttachment	= 1571458007,
	}

	public static class ClassIDTypeExtention
	{
		public static int ToInt(this ClassIDType _this)
		{
			return (int)_this;
		}

		public static bool IsAsset(this ClassIDType _this)
		{
			return IsAsset(_this, false);
		}

		public static bool IsAsset(this ClassIDType _this, bool isSafe)
		{
			switch(_this)
			{
				case ClassIDType.Object:
					throw new NotSupportedException();

				case ClassIDType.GlobalGameManager:
				case ClassIDType.Material:
				case ClassIDType.Texture2D:
				case ClassIDType.Mesh:
				case ClassIDType.Shader:
				case ClassIDType.TextAsset:
				case ClassIDType.PhysicsMaterial2D:
				case ClassIDType.AnimationClip:
				case ClassIDType.AudioClip:
				case ClassIDType.Cubemap:
				case ClassIDType.Avatar:
				case ClassIDType.AnimatorController:
				case ClassIDType.MonoScript:
				case ClassIDType.Font:
				case ClassIDType.NamedObject:
				case ClassIDType.PhysicMaterial:
				case ClassIDType.BuildSettings:
				case ClassIDType.AssetBundle:
				case ClassIDType.MovieTexture:
				case ClassIDType.TerrainData:
				case ClassIDType.Sprite:
				case ClassIDType.AnimatorOverrideController:
				case ClassIDType.Prefab:
				case ClassIDType.SpriteAtlas:
					return true;

				case ClassIDType.GameObject:
				case ClassIDType.Component:
				case ClassIDType.Transform:
				case ClassIDType.MeshRenderer:
				case ClassIDType.Renderer:
				case ClassIDType.MeshFilter:
				case ClassIDType.Animator:
				case ClassIDType.Light:
				case ClassIDType.Animation:
				case ClassIDType.SkinnedMeshRenderer:
				case ClassIDType.TerrainCollider:
				case ClassIDType.ParticleSystem:
				case ClassIDType.ParticleSystemRenderer:
				case ClassIDType.SpriteRenderer:
				case ClassIDType.Terrain:
				case ClassIDType.CanvasRenderer:
				case ClassIDType.Canvas:
				case ClassIDType.RectTransform:
					return false;

				default:
					if(isSafe)
					{
						return false;
					}
					throw new NotImplementedException($"{nameof(ClassIDType)} {_this}");
			}
		}

		public static bool IsTransform(this ClassIDType _this)
		{
			return _this == ClassIDType.Transform || _this == ClassIDType.RectTransform;
		}
	}
}
