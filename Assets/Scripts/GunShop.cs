using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GunShop : MonoBehaviour {

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.X) && G.coins > 0) {
			G.coins = 0;
			G.item = G.GUN_ITEM;
		}
		if (Input.GetKeyDown (KeyCode.Escape)) {
			G.prevScene = G.GUNSHOP_SCENE;
			SceneManager.LoadScene (G.STREET_SCENE);
		}

	}
}
