using UnityEngine;
using System.Collections;

public class FloorScript : MonoBehaviour {
	
	int old_player_floor = 0;
	// Use this for initialization
	void Start () {
	
	}
	

	// Update is called once per frame
	void Update () {

		int new_player_floor = (int) GameObject.Find("Player").transform.position.y/10;
		int diff = new_player_floor - old_player_floor;
		Vector3 pos = transform.position;
		if (diff != 0) {
			pos.y += 10f * diff;
			transform.position = pos;
			old_player_floor = new_player_floor;
		}
		if (Input.GetKeyDown(KeyCode.X)) {
			int currFloor = (int) pos.y / 10;
			Debug.Log(currFloor);
			Debug.Log (new_player_floor);
			if (currFloor > new_player_floor) {
				pos.y -= 20f;
				transform.position = pos;
			} else  {
				pos.y += 20f;
				transform.position = pos;
			}
		}
	}
}
