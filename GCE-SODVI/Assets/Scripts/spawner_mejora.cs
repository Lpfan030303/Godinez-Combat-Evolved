using UnityEngine;
using System.Collections;

public class spawner_mejora : MonoBehaviour {

	public GameObject objeto;
	private int call;
	public int nbeca;
	private Vector3 spawn;
	public float tiempo_inicial;
	public float tiempo_entre;
	public GameObject superficie;
	private Transform coordi;


	// Use this for initialization
	void Start () {

		coordi = superficie.transform;

		InvokeRepeating ("Spawning", tiempo_inicial, tiempo_entre);  //spawnea un objeto en tiempo_inicial cada tiempo_entre
	}
	
	// Update is called once per frame
	void Update () {
		if (call == nbeca)
			CancelInvoke ();
	}

	void Spawning (){

		spawn.x = Random.Range (((coordi.position.x)-(coordi.localScale.x)/2)+0.5f, ((coordi.position.x)+(coordi.localScale.x)/2)-0.5f);
		spawn.y =  coordi.position.y;
		spawn.z = Random.Range (((coordi.position.z)-(coordi.localScale.z)/2)+0.5f, ((coordi.position.z)+(coordi.localScale.z)/2)-0.5f);

		Instantiate (objeto, spawn, Quaternion.identity);
		call++;

	}
}
