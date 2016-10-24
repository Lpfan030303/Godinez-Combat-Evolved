using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour {
	/// ==========================
	public float velocidadavance;
	public float fuerzasalto;
	public float resistencia;
	private float time;
	private float timetoaatack;
	public float damage;

	public Transform attackpoint;
	public LayerMask whattoattack;

	public Transform groundcheckpoint;
	public LayerMask objetosuelo;

	private Rigidbody2D body;
	private Vector2 movement;

	private float horInput;
	private bool jumInput;
	private bool suelo;
	private bool facingright;

	private bool segundosalto;
	private bool ataque;
	public bool defensa;
	private bool shot;

	private Animator anim;

	/// ==========================
	void Start () {
		this.body = this.GetComponent <Rigidbody2D> ();
		this.movement = new Vector2 ();
		this.suelo = false;	
		this.anim = this.GetComponent<Animator> ();
		this.facingright = true;
		this.ataque = false;
		this.defensa = false;
		this.shot = false;
		this.time = 0;
		this.timetoaatack = 1;
	}
	
	/// ==========================
	void Update () {
		this.horInput = Input.GetAxis ("Horizontal");
		this.jumInput = Input.GetKey (KeyCode.UpArrow);
		this.ataque = Input.GetKey (KeyCode.J);
		this.defensa = Input.GetKeyDown (KeyCode.K);
		this.shot = Input.GetKey (KeyCode.L);

		if((this.horInput<0) && (this.facingright)){
			this.Flip();
			this.facingright = false;
		}else if((this.horInput>0) && (!this.facingright)){
			this.Flip();
			this.facingright = true;
		}

		if (this.defensa) {
			this.anim.SetBool ("defensa", true);
			this.body.SendMessage ("attack", this.resistencia);
		}else {
			this.anim.SetBool ("defensa", false);
		}

		if (this.ataque) {
			this.anim.SetBool ("atack", true);
			this.time += Time.deltaTime;
			if (this.time > this.timetoaatack) {
				this.time = 0;
				this.attack();
			}
		} else {
			this.anim.SetBool ("atack", false);
		}

		if (this.shot) {
			this.anim.SetBool ("shot", true);
		} else {
			this.anim.SetBool ("shot", false);
		}
				
		this.anim.SetFloat ("HorSpeed", Mathf.Abs(this.body.velocity.x));
		this.anim.SetFloat ("VerSpeed", Mathf.Abs (this.body.velocity.y));

		if (Physics2D.OverlapCircle (this.groundcheckpoint.position, 0.02f, this.objetosuelo)) {
			this.suelo = true;
			this.segundosalto = true;
		} else {
			this.suelo = false;
		}
	}
	/// ==========================
	void FixedUpdate(){
		this.movement = this.body.velocity;

		this.movement.x = horInput * velocidadavance;
		if (this.jumInput && this.suelo){
			this.segundosalto = true;
			this.movement.y = fuerzasalto;
			if (this.jumInput && this.segundosalto) {
				this.movement.y = fuerzasalto;
				this.segundosalto = false;
			}
		}


			
		this.body.velocity = this.movement;
	}

	/// ==========================
	void Flip(){
		Vector3 scale = this.transform.localScale;
		scale.x *= (-1);
		this.transform.localScale = scale;
	}

	void attack(){
		Collider2D tmp = Physics2D.OverlapCircle (this.attackpoint.position, 0.02f, this.whattoattack);

		if (tmp){
			tmp.gameObject.SendMessage ("Hurt", this.damage);
		}
	}

	public void OnGetKill(){
		//GameMaster.current.AddPuntuation (-100);
	}
}
