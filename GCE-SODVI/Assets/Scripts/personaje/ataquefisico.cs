using UnityEngine;
using System.Collections;

public class ataquefisico : MonoBehaviour {
	public Transform puntodeataque;

	public int armaactual;

	public float da;
	public float vel;
	//public Animator animacionarma;

	private bool ataque;
	public float time;

	//public Animator animacionpersonaje;

	void Start () {
		this.time = 0;
		this.ataque = false;
		//this.animacionpersonaje = this.GetComponent<Animator> ();
	}

	void Update () {

		controladorarmas controlador = GetComponent<controladorarmas> ();
		this.armaactual = controlador.armaactualfisica;
		this.da = controlador.dañoFisico[armaactual];
		this.vel = controlador.velocidadAtaqueFisico[armaactual];
		//this.animacionarma = controlador.animacionesFisico[armaactual];

		this.ataque = Input.GetKey (KeyCode.J);
		
		if (this.ataque) {
			//this.animacionpersonaje.SetBool ("atack", true);
			//this.animacionarma.SetBool ("atack", true);

			this.time += Time.deltaTime;
			if (this.time >= this.vel) {
				this.attack();
				this.time = 0;
				}
		} else {
			//this.animacionpersonaje.SetBool ("atack", false);
			//this.animacionarma.SetBool ("atack", false);
		}
	}

	void attack(){
		Collider[] tmp = Physics.OverlapSphere (this.puntodeataque.position, 0.02f);

		if (tmp!= null){
			tmp[0].SendMessage ("Hurt", this.da);
		}
	}
}

