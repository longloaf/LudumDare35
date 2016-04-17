using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Pharmacy : MonoBehaviour {


	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) {
			G.prevScene = G.PHARMACY_SCENE;
			SceneManager.LoadScene (G.STREET_SCENE);
		}
	
	}
}
