using UnityEngine;
using System.Collections;

public class TeleporterScript : MonoBehaviour {

	public delegate void CallPairedTeleporter();
	public static event CallPairedTeleporter onTele;
	public static event CallPairedTeleporter offTele;
	private Animator animator;
	private Vector3 location;
	private GameObject player;
	private int startTime;
	public GameObject pair;

	
	// Use this for initialization
	void Start()
	{
		animator = this.GetComponent<Animator>();
		location = pair.transform.position;
	}
	
	// Update is called once per frame
	void Update()
	{
		location = pair.transform.position;

	}
	void OnTriggerStay(Collider other) {
		if (other.gameObject.CompareTag ("Player")) {
			onTele();
			if (location.x > 0 && location.z <= -9.5) {
				animator.SetBool("Teleport", true);
			} else {
				animator.SetBool("Teleport", false);
			}
			startTime = Time.frameCount;
			player = other.gameObject;
			Vector3 player_posn = other.transform.position;
			if (Input.GetKeyDown(KeyCode.Z) || Time.frameCount-startTime >= 2) {
				other.transform.position = location;
			} else {
				//animate
			}
			 
		}
	}
	void OnTriggerExit(Collider other) {
		if (other.gameObject.CompareTag ("Player")) {
			offTele();
			animator.SetBool("Teleport", false);
		
		}
	}
	void OnEnable()
	{
		PairedTeleporterScript.onTele += React;
		PairedTeleporterScript.offTele += Deact;
	}
	
	
	void OnDisable()
	{
		PairedTeleporterScript.onTele -= React;
		PairedTeleporterScript.offTele -= Deact;
	}
	
	
	void React()
	{
		if (location.x > 0 && location.z <= -9.5) {
			animator.SetBool("Teleport", true);
		} else {
			animator.SetBool("Teleport", false);
		}
	}
	void Deact()
	{
		animator.SetBool("Teleport", false);
	}
}