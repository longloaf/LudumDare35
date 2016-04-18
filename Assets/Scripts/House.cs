using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class House : MonoBehaviour {

	public Transform womanOriginPos;
	public Transform streetPos;

	public Transform woman;
	SpriteRenderer womanSprRend;

	public GameObject w;
	public GameObject m;
	bool theEndFlag = false;

	void Awake()
	{
		womanSprRend = woman.GetComponent<SpriteRenderer> ();

		if (G.prevScene == G.STREET_SCENE) {
			woman.position = streetPos.position;
			womanSprRend.flipX = true;
		} else {
			woman.position = womanOriginPos.position;
			womanSprRend.flipX = false;
		}
	}

	void Update()
	{
		if (!theEndFlag) {
			if (m == null || w == null) {
				theEndFlag = true;
				Invoke ("GotoTheEnd", 5);
			}
		}
	}

	void GotoTheEnd()
	{
		SceneManager.LoadScene (G.THEEND_SCENE);
	}
}
