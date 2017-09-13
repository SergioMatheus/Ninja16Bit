using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentacao : MonoBehaviour {
	private Animator anim;
	public float speed;
	public float jumpforce;
	private bool eLadoDireito;
	float horizontal;
	void Start () {
		anim = GetComponent <Animator> ();
		eLadoDireito = transform.localScale.x > 0;
	}
	
	// Update is called once per frame
	void Update () {

		horizontal =Input.GetAxis("Horizontal");
		Debug.Log (anim);
		movimentacaopersonagem ();
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);

		if (screenPosition.y < 0)
		{
			Die();
		}
	
	}

		void movimentacaopersonagem(){

		anim.SetInteger ("controle", 0);
		if(Input.GetButton("W")){
		transform.Translate(Vector2.up*jumpforce*Time.deltaTime);
			anim.SetInteger ("controle", 1);
		}
		if(Input.GetButton("D")){
			transform.Translate(Vector2.right*(speed)*Time.deltaTime);
			mudarDirecao (horizontal);

			anim.SetInteger ("controle", 1);
		}	
			
		if(Input.GetButton("A")){
			
			transform.Translate(Vector2.right*(-speed)*Time.deltaTime);
			mudarDirecao (horizontal);
			anim.SetInteger ("controle", 1);
		}
	}


	private void mudarDirecao(float horizontal){
		if (horizontal > 0 && !eLadoDireito || horizontal < 0 && eLadoDireito) {
			eLadoDireito = !eLadoDireito;
			transform.localScale = new Vector3 (-transform.localScale.x ,transform.localScale.y,transform.localScale.z);
		}
		
		}


	void Die(){
		Application.LoadLevel(Application.loadedLevel);
	}
}
