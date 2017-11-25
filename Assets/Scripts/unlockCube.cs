using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class unlockCube : MonoBehaviour {

	public Text keyText;

	void OnTriggerEnter(Collider other) {
		print ("keys: " + collectObject.keyCount);
		if (other.gameObject.CompareTag ("Locked") ) {
			if (collectObject.keyCount > 0)
			{
				other.gameObject.SetActive (false);
				collectObject.keyCount -= 1;	
				keyText.text = "x" + collectObject.keyCount.ToString();
			}
		}
	}


}
