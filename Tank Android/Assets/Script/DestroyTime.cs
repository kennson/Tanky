﻿using UnityEngine;
using System.Collections;

public class DestroyTime : MonoBehaviour {

	public float lifetime;
	
	void Start()
	{
		Destroy (gameObject, lifetime);
	}
}
