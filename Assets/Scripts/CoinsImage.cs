using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CoinsImage : MonoBehaviour {

	Image img;

	public Sprite spr10;
	public Sprite spr0;

	void Awake()
	{
		img = GetComponent<Image> ();
	}

	void Update()
	{
		if (G.coins > 0) {
			img.sprite = spr10;
		} else {
			img.sprite = spr0;
		}
	}
}
