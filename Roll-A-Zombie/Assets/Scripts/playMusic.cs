using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playMusic : MonoBehaviour {

	public static playMusic Instance;
	void Awake()
	{

		if (Instance)
			DestroyImmediate (gameObject);
		else {
			DontDestroyOnLoad (gameObject);
			Instance = this;

		}
	}
	
}
