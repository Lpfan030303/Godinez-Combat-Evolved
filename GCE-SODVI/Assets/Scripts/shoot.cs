using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

	public GameObject bullet;
	public int speed;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Mouse0)) {
			GameObject projectile = Instantiate (bullet, bullet.transform.position, bullet.transform.rotation) as GameObject;
			Rigidbody rb = projectile.GetComponent<Rigidbody> ();
			rb.AddForce (transform.forward * speed);
			Destroy (projectile, 2.5f);
		}
			
	}
}
