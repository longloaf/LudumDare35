using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class TheEnd : MonoBehaviour {

	void Awake()
	{
		Invoke ("GotoMenu", 3);
	}

	void GotoMenu()
	{
		SceneManager.LoadScene (G.MENU_SCENE);
	}
}
