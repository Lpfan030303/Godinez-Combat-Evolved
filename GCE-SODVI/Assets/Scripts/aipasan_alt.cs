﻿using UnityEngine;
using System.Collections;

public class aipasan_alt : MonoBehaviour {

	public LayerMask obst;
	public float vel;
	public float dist_obs;
	private Rigidbody rig;
	private Vector3 dir;


	// Use this for initialization
	void Start () {
		rig = GetComponent <Rigidbody> ();
		dir = RandomDir();
		transform.rotation = Quaternion.LookRotation (dir);
	}

	// Update is called once per frame
	void Update () {
		rig.velocity = dir * vel;
		if (Physics.Raycast (transform.position, transform.forward, dist_obs, obst)) {
			dir = RandomDir ();
			transform.rotation = Quaternion.LookRotation (dir);
		}
	}

	Vector3 RandomDir (){
		System.Random ran = new System.Random ();
		int i = ran.Next (0, 3);
		Vector3 temp = new Vector3();
		if (i == 0)
			temp = transform.forward;
		else if (i == 1)
			temp = -transform.forward;
		else if (i == 2)
			temp = transform.right;
		else if (i == 3)
			temp = -transform.right;


		return temp;	
	}
}
