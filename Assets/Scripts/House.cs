using UnityEngine;
using System.Collections;

public class House : MonoBehaviour {

	public Transform womanOriginPos;
	public Transform streetPos;

	public Transform woman;
	SpriteRenderer womanSprRend;

	void Awake()
	{
		womanSprRend = woman.GetComponent<SpriteRenderer> ();

		if (G.prevScene == G.STREET_SCENE) {
			woman.position = streetPos.position;
			womanSprRend.flipX = true;
		} else {
			woman.position = womanOriginPos.position;
			womanSprRend.flipX = false;
		}
	}
}
