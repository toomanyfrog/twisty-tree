using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

	void OnTriggerEnter(Collider other) {

		if (other.gameObject.CompareTag ("Stump")) {
			//do something.
		}
	}
}
