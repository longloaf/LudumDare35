using UnityEngine;
using System.Collections;

public class Cam : MonoBehaviour {

	public Transform target;

	public SpriteRenderer bgLeft;
	public SpriteRenderer bgRight;

	float leftX;
	float rightX;

	Camera cam;

	void Awake()
	{
		leftX = bgLeft.bounds.min.x;
		rightX = bgRight.bounds.max.x;

		cam = GetComponent<Camera> ();

	}

	void Update ()
	{
		float x = transform.position.x;
		if (target != null) {
			x = target.position.x;
		}
			
		float halfWidth = cam.orthographicSize * cam.aspect;
		if ((x - halfWidth) < leftX) {
			x = leftX + halfWidth;
		}
		if ((x + halfWidth) > rightX) {
			x = rightX - halfWidth;
		}

		Vector3 pos = transform.position;
		pos.x = x;
		transform.position = pos;
	}

}
