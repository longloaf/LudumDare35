using UnityEngine;
using System.Collections;

public class Street : MonoBehaviour {

	public Transform housePos;
	public Transform pharmacyPos;
	public Transform gunShopPos;

	public Transform woman;
	SpriteRenderer womanSprRend;

	void Awake()
	{
		womanSprRend = woman.GetComponent<SpriteRenderer> ();

		if (G.prevScene == G.HOUSE_SCENE) {
			woman.position = housePos.position;
			womanSprRend.flipX = true;
		} else if (G.prevScene == G.PHARMACY_SCENE) {
			woman.position = pharmacyPos.position;
			womanSprRend.flipX = false;
		} else {
			woman.position = gunShopPos.position;
			womanSprRend.flipX = false;
		}
	}
}
