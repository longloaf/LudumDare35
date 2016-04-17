using UnityEngine;
using System.Collections;

public class Woman : MonoBehaviour {

	public float speed = 1;

	SpriteRenderer spriteRenderer;
	Rigidbody2D rb2d;
	Animator anim;

	void Awake()
	{
		spriteRenderer = GetComponent<SpriteRenderer> ();
		rb2d = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}

	void FixedUpdate()
	{
		float velx = 0;
		if (Input.GetKey(KeyCode.LeftArrow)) {
			velx -= speed;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			velx += speed;
		}

		rb2d.velocity = new Vector2 (velx, rb2d.velocity.y);

		if (velx > 0) {
			spriteRenderer.flipX = false;
		} else if (velx < 0) {
			spriteRenderer.flipX = true;
		}
		anim.SetBool ("Walk", velx != 0);
	}
}

