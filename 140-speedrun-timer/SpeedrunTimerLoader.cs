﻿using UnityEngine;

namespace SpeedrunTimerMod
{
	class SpeedrunTimerLoader : MonoBehaviour
	{
		static GameObject modObject;

		public void Awake()
		{
			if (modObject != null)
				return;
			modObject = new GameObject();
			modObject.AddComponent<SpeedrunTimer>();
			DontDestroyOnLoad(modObject);
			Destroy(this);
		}
	}
}
