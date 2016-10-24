using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class vida : MonoBehaviour {
	public float vidapersonaje;
	public float hp;
	public Slider Barravida;

	public GameObject muerteanim;
	public int vidascontador;
	// Use this for initialization
	void Start () {
		this.hp = this.vidapersonaje;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Hurt(float damage){
		this.hp -= damage;

		if (this.hp <= 0) {
			this.hp = 0;
			this.vidascontador -= 1;
			if (vidascontador <= 0) {
				//GameObject boom = Instantiate (this.muerteanim, this.transform.position, Quaternion.identity) as GameObject;

				//Destroy (boom, 0.5f);
				Destroy (this.gameObject);
			} else {
				this.hp = this.vidapersonaje;
			}
		}

		if (this.Barravida) {
			this.Barravida.value = this.hp;
		}
	}

}
