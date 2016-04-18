using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Pharmacy : MonoBehaviour {


	public GameObject buySound;
	public GameObject noMoneySound;
	public GameObject doorSound;

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.X)) {
			if (G.coins > 0) {
				G.coins = 0;
				G.item = G.MEDICINE_ITEM;
				InstSnd (buySound);
			} else {
				InstSnd (noMoneySound);
			}
		}
		if (Input.GetKeyDown (KeyCode.C)) {
			G.prevScene = G.PHARMACY_SCENE;
			SceneManager.LoadScene (G.STREET_SCENE);
			InstSnd (doorSound);
		}
	
	}

	void InstSnd(GameObject s)
	{
		GameObject snd = Instantiate<GameObject> (s);
		snd.transform.position = Vector3.zero;
	}
}
