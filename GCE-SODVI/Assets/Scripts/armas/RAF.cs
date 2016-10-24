using UnityEngine;
using System.Collections;

public class RAF : MonoBehaviour {
	public int[] numerodearma;
	public Sprite[] logos;
	public float time;
	public float cambio;
	public int estadoactual;
	public Sprite logoactual;
	// Use this for initialization
	void Start () {
		this.time = 0;
		this.estadoactual = 0;
		this.logoactual = this.logos [0];
	}

	// Update is called once per frame
	void Update () {
		this.time += Time.deltaTime;
		if (this.time > this.cambio) {
			this.estadoactual = Random.Range (1,8);
			this.logoactual = this.logos [this.estadoactual];
			this.time = 0;
		}
	}
}
