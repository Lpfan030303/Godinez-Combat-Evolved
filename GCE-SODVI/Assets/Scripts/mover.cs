using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour {

	public float vel;
	private Rigidbody rbody;

	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
		//controles de movimiento

		if (Input.GetKey (KeyCode.A))
			rbody.AddForce (-vel, 0f, 0f, ForceMode.Impulse);

		if (Input.GetKey (KeyCode.S))
			rbody.AddForce (0f, 0f, -vel, ForceMode.Impulse);

		if (Input.GetKey (KeyCode.W))
			rbody.AddForce (0f, 0f, vel, ForceMode.Impulse);

		if (Input.GetKey (KeyCode.D))
			rbody.AddForce (vel, 0f, 0f, ForceMode.Impulse);
		
	}

}
