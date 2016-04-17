using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GunShop : MonoBehaviour {

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) {
			G.prevScene = G.GUNSHOP_SCENE;
			SceneManager.LoadScene (G.STREET_SCENE);
		}

	}
}
