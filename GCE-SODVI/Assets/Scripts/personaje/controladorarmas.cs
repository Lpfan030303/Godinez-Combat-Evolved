using UnityEngine;
using System.Collections;

public class controladorarmas : MonoBehaviour {
	private int estado;

	public float[] dañoFisico;
	public float[] velocidadAtaqueFisico;
	public Sprite[] imagenesFisico;
	public Animator[] animacionesFisico;

	public float[] dañoDistancia;
	public float[] velocidadAtaqueDistancia;
	public float[] velocidadProyectil;
	public Sprite[] imagenesDistancia;
	public Animator[] animacionesDistancia;

	public int armaactualfisica;
	public int armaactualdistancia;

	// Use this for initialization
	void Start () {
		this.armaactualfisica = 0;
		this.armaactualdistancia = 0;

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "armafisica") {
			RAF arma = GetComponent<RAF> ();
			this.armaactualfisica = arma.estadoactual;
		}

		if (collision.gameObject.tag == "armadistancia") {
			RAD arma = GetComponent<RAD> ();
			this.armaactualdistancia = arma.estadoactual;
		}
	}

}