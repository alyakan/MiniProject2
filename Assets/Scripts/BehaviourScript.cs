using UnityEngine;
using System.Collections;

public class BehaviourScript : MonoBehaviour {
	private Animator myAnimator;
	private Rigidbody rbody;
	float moveX;
	float moveZ;



	// Use this for initialization
	void Start () {
		myAnimator = GetComponent<Animator> ();
		rbody = GetComponent<Rigidbody> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		Keyboard ();

		myAnimator.SetFloat ("VSpeed", Input.GetAxis ("Vertical"));
		myAnimator.SetFloat ("HSpeed", Input.GetAxis ("Horizontal"));



	}

	void UpdateFixed () {

		// move ();
	}

	void Keyboard(){
		if (Input.GetKey (KeyCode.Q)) {
			// actually rotate charater
			transform.Rotate (Vector3.down * Time.deltaTime * 100.0f);
			if ((Input.GetAxis ("Vertical") == 0f) && (Input.GetAxis ("Horizontal") == 0f))
				myAnimator.SetBool ("TurningLeft", true);
		} else if (Input.GetKey (KeyCode.E)) {
			// actually rotate charater
			transform.Rotate (Vector3.up * Time.deltaTime * 100.0f);
			if ((Input.GetAxis ("Vertical") == 0f) && (Input.GetAxis ("Horizontal") == 0f))
				myAnimator.SetBool ("TurningRight", true);
		} else {
				myAnimator.SetBool ("TurningLeft", false);
				myAnimator.SetBool ("TurningRight", false);
			}
		}

	void move(){

		// actually move character
		moveX =  Input.GetAxis ("Vertical");
		moveZ = Input.GetAxis ("Horizontal");
		moveX = moveX * 20f * Time.deltaTime;
		moveZ = moveZ * 50f * Time.deltaTime;

		rbody.velocity = new Vector3 (moveX, 0f, moveZ);

	}
}
