using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1_health : MonoBehaviour {

	SpriteRenderer sr;
	public Sprite Player1_health3;
	public Sprite Player1_health2;
	public Sprite Player1_health1;
	public Sprite Player1_health0;

	public void updateHealthPlayer1(int Number)
	{
		GameObject attackDodge = GameObject.Find("Attack/dodge");
		Attack attackScript = attackDodge.GetComponent<Attack>();
		//attackScript.player1_hp = 3;

		if (attackScript.player1_hp == 3) { //If the player 1 health = 3 then load the 3 health sprite
			sr = GetComponent<SpriteRenderer> ();
			sr.sprite = Player1_health3;
		}

		if (attackScript.player1_hp == 2) { //If the player 2 health = 2 then load the 2 health sprite
			sr = GetComponent<SpriteRenderer> ();
			sr.sprite = Player1_health2;
		}

		if (attackScript.player1_hp == 1) { //If the player 2 health = 1 then load the 1 health sprite
			sr = GetComponent<SpriteRenderer> ();
			sr.sprite = Player1_health1;
		}

		if (attackScript.player1_hp == 0) { //If the player 2 health = 0 then load the 0 health sprite
			sr = GetComponent<SpriteRenderer> ();
			sr.sprite = Player1_health0;
		}
	}
}
