using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Moves
{
	attack,
	dodge
}

public class Attack : MonoBehaviour {

	public GameManager gameManager;
	public bool player1;
	public bool player2;

	Moves player1Move;
	Moves player2Move;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayerAttack()
	{
		if (gameManager.CurrentPlayer == 1)
		{
			player1Move = Moves.attack;

			Debug.Log("Player 1 attack");	
		}

		if (gameManager.CurrentPlayer == 2)
		{
			Debug.Log("Player 2 attack");
		}

		gameManager.NextTurn ();
	}

	public void Dodge()
	{
		if (gameManager.CurrentPlayer == 1)
		{
			Debug.Log("Player 1 dodge");	
		}

		if (gameManager.CurrentPlayer == 2)
		{
			Debug.Log("Player 2 dodge");
		}

		gameManager.NextTurn ();
	}

	public void Fight()
	{
		
	}


}
	