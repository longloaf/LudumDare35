using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Menu : MonoBehaviour {

	void Awake()
	{
		G.prevScene = G.MENU_SCENE;
		G.coins = 10;
		G.item = G.NO_ITEM;
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.X)) {
			SceneManager.LoadScene (G.HOUSE_SCENE);
		}
	}
}
