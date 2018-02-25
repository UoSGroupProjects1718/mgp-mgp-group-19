using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2_health : MonoBehaviour {

	SpriteRenderer sr;
	public Sprite Player2_health3;
	public Sprite Player2_health2;
	public Sprite Player2_health1;
	public Sprite Player2_health0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void updateHealthPlayer2(int Number)
	{
		GameObject attackDodge2 = GameObject.Find("Attack/dodge");
		Attack attackScript = attackDodge2.GetComponent<Attack>();

		if (attackScript.player2_hp == 3) { //If the player 2 health = 3 then load the 3 health sprite
			sr = GetComponent<SpriteRenderer> ();
			sr.sprite = Player2_health3;
		}

		if (attackScript.player2_hp == 2) { //If the player 2 health = 2 then load the 2 health sprite
			sr = GetComponent<SpriteRenderer> ();
			sr.sprite = Player2_health2;
		}

		if (attackScript.player2_hp == 1) { //If the player 2 health = 1 then load the 1 health sprite
			sr = GetComponent<SpriteRenderer> ();
			sr.sprite = Player2_health1;
		}

		if (attackScript.player2_hp == 0) { //If the player 2 health = 0 then load the 0 health sprite
			sr = GetComponent<SpriteRenderer> ();
			sr.sprite = Player2_health0;
		}
	}
}
