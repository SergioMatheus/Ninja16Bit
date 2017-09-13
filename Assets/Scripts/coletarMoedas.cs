using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class coletarMoedas : MonoBehaviour {

	 
	private int _pontos;
	public Text pontuacao;
	// Use this for initialization
	void Start () {
		_pontos = 0;
		pontuacao.text = "pontos :" + _pontos;
	}
	
	// Update is called once per frame
	void Update () {
		pontuacao.text = "pontos: " + _pontos;

	}
	void OnTriggerEnter (Collider other){
		if (other.tag == "argola") {
			other.gameObject.SetActive (false);
			_pontos++;

		}
	}	


	

	public int GetPontos { get { return _pontos; } } 
	public int SetPontos { set { _pontos = value; } } 
	
}
