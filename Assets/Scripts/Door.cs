using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Door : MonoBehaviour {

	public string nextScene;

	void EnterDoor()
	{
		G.prevScene = SceneManager.GetActiveScene ().name;
		SceneManager.LoadScene (nextScene);
	}

}
