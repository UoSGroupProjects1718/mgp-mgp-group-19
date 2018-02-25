using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1_health : MonoBehaviour {

	SpriteRenderer sr;
	public Sprite Player1_health3;
	public Sprite Player1_health2;
	public Sprite Player1_health1;
	public Sprite Player1_health0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void updateHealthPlayer1(int Number)
	{
		GameObject attackDodge = GameObject.Find("Attack/dodge");
		Attack attackScript = attackDodge.GetComponent<Attack>();
		//attackScript.player1_hp = 3;

		if (attackScript.player1_hp == 3) {
			sr = GetComponent<SpriteRenderer> ();
			sr.sprite = Player1_health3;
		}

		if (attackScript.player1_hp == 2) {
			sr = GetComponent<SpriteRenderer> ();
			sr.sprite = Player1_health2;
		}

		if (attackScript.player1_hp == 1) {
			sr = GetComponent<SpriteRenderer> ();
			sr.sprite = Player1_health1;
		}

		if (attackScript.player1_hp == 0) {
			sr = GetComponent<SpriteRenderer> ();
			sr.sprite = Player1_health0;
		}
	}
}
