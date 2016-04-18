using UnityEngine;
using System.Collections;

public class Man : MonoBehaviour {

	public float textRadius = 2;
	public LayerMask textLayerMask;

	public float attackWomanRadius = 5;
	public LayerMask womanLayerMask;
	bool transformFlag = false;
	bool attackFlag = false;

	public float hitRadius = 0.5f;

	public float attackSpeed = 2;

	public GameObject text;

	public Transform woman;

	SpriteRenderer spriteRenderer;
	Animator anim;
	Rigidbody2D rb;

	public GameObject transformSnd;
	public GameObject deathSnd;

	public GameObject door;

	public GameObject deadMan;

	void Awake ()
	{
		spriteRenderer = GetComponent<SpriteRenderer> ();
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D> ();
	}

	void Update ()
	{
		text.SetActive (Physics2D.OverlapCircle (transform.position, textRadius, textLayerMask) && G.item == G.NO_ITEM);

		if (woman != null) {
			spriteRenderer.flipX = woman.position.x < transform.position.x;
		}

		if (!transformFlag && G.item != G.NO_ITEM && Physics2D.OverlapCircle (transform.position, attackWomanRadius, womanLayerMask)) {
			door.SetActive (false);
			transformFlag = true;
			anim.SetTrigger ("Transform");
			GameObject trSnd = Instantiate<GameObject> (transformSnd);
			trSnd.transform.position = transform.position;
		}

		if (attackFlag) {
			if (woman != null) {
				rb.velocity = new Vector2 ((spriteRenderer.flipX ? -1 : 1) * attackSpeed, rb.velocity.y);
				if (Physics2D.OverlapCircle(transform.position, hitRadius, womanLayerMask)) {
					woman.SendMessage("Kill");
				}
			} else {
				rb.velocity = new Vector2 (0, rb.velocity.y);
			}
			anim.SetBool ("Walk", rb.velocity.x != 0);
		}

	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere (transform.position, textRadius);
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere (transform.position, attackWomanRadius);
		Gizmos.color = Color.magenta;
		Gizmos.DrawWireSphere (transform.position, hitRadius);
	}

	public void TransformFinished()
	{
		attackFlag = true;
	}

	public void Kill()
	{
		Destroy (gameObject);
		GameObject snd = Instantiate<GameObject> (deathSnd);
		snd.transform.position = transform.position;

		GameObject dm = Instantiate<GameObject> (deadMan);
		dm.transform.position = transform.position;
	}
}
