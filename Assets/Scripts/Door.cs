using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Door : MonoBehaviour {

	public string nextScene;

	public GameObject doorSound;

	void EnterDoor()
	{
		G.prevScene = SceneManager.GetActiveScene ().name;
		SceneManager.LoadScene (nextScene);

		GameObject snd = Instantiate<GameObject> (doorSound);
		snd.transform.position = transform.position;
	}

}
