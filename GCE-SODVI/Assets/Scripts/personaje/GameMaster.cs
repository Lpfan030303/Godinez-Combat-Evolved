using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class GameMaster : MonoBehaviour {
	public static GameMaster current;

	//inicializador de prefaps

	public GameObject player1;
	public GameObject player2;
	public GameObject player3;
	public GameObject player4;

	//posiciones iniciales de los personajes

	public Vector3 posicioninicialuno;
	public Vector3 posicioninicialdos;
	public Vector3 posicioninicialtres;
	public Vector3 posicioninicialcuatro;
	private int puntuation;

	// 
	void Start () {	
		GameMaster.current = this;
		/*
		this.posicioninicialuno = GameObject.FindGameObjectWithTag ("jugador1").transform.position;
		this.posicioninicialdos = GameObject.FindGameObjectWithTag ("jugador2").transform.position;
		this.posicioninicialtres = GameObject.FindGameObjectWithTag ("jugador3").transform.position;
		this.posicioninicialcuatro = GameObject.FindGameObjectWithTag ("jugador4").transform.position;
		*///this.UpdatePuntText();
	}

	void ControladorDePersonajes(bool per1, bool per2, bool per3, bool per4){
		if (!per1) {
			this.player1.SetActive (false);
		}

		if (!per2) {
			this.player2.SetActive (false);
		}

		if (!per3) {
			this.player3.SetActive (false);
		}

		if (!per4) {
			this.player4.SetActive (false);
		}
	}
}
