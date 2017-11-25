using UnityEngine;
using System.Collections;

public class RotateStorey : MonoBehaviour {
	
	public float speed = 55.0f;
	private float rotation = 0.0f;
	private Quaternion qTo = Quaternion.identity;
	public static bool isRotating = false;
	
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.C)) {
			float frame_floor = Mathf.Floor(GameObject.Find("SelectFrame").GetComponent<Transform>().position.y/10);
			float my_floor = Mathf.Floor(transform.position.y/10);
			CharacterController controller = GameObject.Find("Player").GetComponent<CharacterController>();
			if (controller.isGrounded && my_floor == frame_floor) {
				isRotating = true;
				rotation += 90.0f;
				qTo = Quaternion.Euler(0.0f, rotation, 0.0f);
			} 
		}
		
		transform.rotation = Quaternion.RotateTowards(transform.rotation, qTo, speed * Time.deltaTime);
		
	}
}