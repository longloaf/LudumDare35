using UnityEngine;
using System.Collections;

public class Man : MonoBehaviour {

	public float textRadius = 2;
	public LayerMask textLayerMask;

	public GameObject text;

	public Transform woman;

	SpriteRenderer spriteRenderer;

	void Awake ()
	{
		spriteRenderer = GetComponent<SpriteRenderer> ();
	}

	void Update ()
	{
		text.SetActive (Physics2D.OverlapCircle (transform.position, textRadius, textLayerMask));

		if (woman != null) {
			spriteRenderer.flipX = woman.position.x < transform.position.x;
		}
	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere (transform.position, textRadius);
	}
}
