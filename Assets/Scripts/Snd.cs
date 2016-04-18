using UnityEngine;
using System.Collections;

public class Snd : MonoBehaviour {

	public float lifeTime = 3;

	void Awake()
	{
		DontDestroyOnLoad (gameObject);
		Destroy (gameObject, lifeTime);
	}
}
