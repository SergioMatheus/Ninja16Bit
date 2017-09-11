using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentacao : MonoBehaviour {
	private Animator anim;
	public float speed;
	public float jumpforce;

	void Start () {
		anim = GetComponent <Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (anim);
		movimentacaopersonagem ();
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0)
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
			anim.SetInteger ("controle", 1);
		}	
			
		if(Input.GetButton("A")){
		transform.Translate(Vector2.right*(-speed)*Time.deltaTime);
		anim.SetInteger ("controle", 1);
		}
	}


	void Die(){
		Application.LoadLevel(Application.loadedLevel);
	}
}
