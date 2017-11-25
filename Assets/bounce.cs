using UnityEngine;
using System.Collections;

public class bounce : MonoBehaviour {

	float init = 0;
	float bounceSpeed = 10f;
	Vector3 upVec;
	Vector3 downVec;

	private bool goingUp = true;

	// Use this for initialization
	void Start () {
		Vector3 upVec = new Vector3 (0, 1, 0) * Time.deltaTime * bounceSpeed;
		Vector3 downVec = new Vector3 (0, -1, 0) * Time.deltaTime * bounceSpeed;
		init = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y > init + 10) {
			transform.Translate (upVec);
			goingUp = !goingUp;
		} else if (transform.position.y < init - 10) {
			transform.Translate (downVec);
			goingUp = !goingUp;
		} else if (goingUp) {
			transform.Translate (upVec);
		} else {
			transform.Translate (downVec);
		}
	}
}
