using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemsImage : MonoBehaviour {

	Image img;

	public Sprite noItem;
	public Sprite medicineItem;
	public Sprite gunItem;

	void Awake()
	{
		img = GetComponent<Image> ();
	}

	void Update()
	{
		if (G.item == G.MEDICINE_ITEM) {
			img.sprite = medicineItem;
		} else if (G.item == G.GUN_ITEM) {
			img.sprite = gunItem;
		} else {
			img.sprite = noItem;
		}
	}
}
