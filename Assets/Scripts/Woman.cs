using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Woman : MonoBehaviour {

	public float speed = 1;

	public float doorRadius = 1;
	public LayerMask doorLayerMask;

	SpriteRenderer spriteRenderer;
	Rigidbody2D rb2d;
	Animator anim;

	bool fire = false;
	public LayerMask manLayerMask;

	void Awake()
	{
		spriteRenderer = GetComponent<SpriteRenderer> ();
		rb2d = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}

	void FixedUpdate()
	{
		float velx = 0;
		if (!fire) {
			if (Input.GetKey (KeyCode.LeftArrow)) {
				velx -= speed;
			}
			if (Input.GetKey (KeyCode.RightArrow)) {
				velx += speed;
			}
		}

		rb2d.velocity = new Vector2 (velx, rb2d.velocity.y);

		if (velx > 0) {
			spriteRenderer.flipX = false;
		} else if (velx < 0) {
			spriteRenderer.flipX = true;
		}
		anim.SetBool ("Walk", velx != 0);
		anim.SetBool ("Gun", G.item == G.GUN_ITEM);
	}

	void Update()
	{
		Collider2D door = Physics2D.OverlapCircle (transform.position, doorRadius, doorLayerMask);
		if (door != null && Input.GetKeyDown (KeyCode.UpArrow)) {
			door.SendMessage ("EnterDoor");
		}

		if (G.item == G.GUN_ITEM && Input.GetKeyDown (KeyCode.X)) {
			Debug.Log ("Bang");
			fire = true;
			anim.SetTrigger ("Fire");
			RaycastHit2D rs = Physics2D.Raycast (transform.position, new Vector2 (spriteRenderer.flipX ? -1 : 1, 0), 8, manLayerMask);
			if (rs.collider != null) {
				rs.collider.SendMessageUpwards ("Kill");
			}
		}
	}

	public void FireFinished()
	{
		fire = false;
	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere (transform.position, doorRadius);
	}

	public void Kill()
	{
		Destroy (gameObject);
	}

}

