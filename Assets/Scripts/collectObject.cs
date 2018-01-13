using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class collectObject : MonoBehaviour {

	public static int nutCount;
	public static int keyCount;

	public static bool gotHeartKey;

	public Text keyText;
	public Text nutText;

    public Image finish;
	public Image heartKey;

	// Use this for initialization
	void Start () {
		keyCount = 0;
		nutCount = 0;
		heartKey.enabled = false;
		nutText.text = "x" + nutCount.ToString ();
		keyText.text = "x" + keyCount.ToString ();
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Nut")) {
			other.gameObject.SetActive (false);
			nutCount += 1;
			updateNutText ();
		}
		if (other.gameObject.CompareTag ("Key")) {
			other.gameObject.SetActive (false);
			keyCount += 1;
			updateKeyText();
		}
		if (other.gameObject.CompareTag ("Special")) {
			other.gameObject.SetActive (false);
			gotHeartKey = true;
			heartKey.enabled = true;
		}
        if (other.gameObject.CompareTag("Locked"))
        {
            if (keyCount > 0)
            {
                keyCount -= 1;
                updateKeyText();
                other.gameObject.SetActive(false);
            }
        }
        if (other.gameObject.CompareTag("Home"))
        {
            if (gotHeartKey)
            {
                other.gameObject.SetActive(false);
                heartKey.enabled = false;
            }
        }
        if (other.gameObject.CompareTag("Finish"))
        {
            finish.gameObject.SetActive(true);
        }
	}


    void updateNutText() {
		nutText.text = "x" + nutCount.ToString ();
	}

	void updateKeyText() {
		keyText.text = "x" + keyCount.ToString ();
	}
}
