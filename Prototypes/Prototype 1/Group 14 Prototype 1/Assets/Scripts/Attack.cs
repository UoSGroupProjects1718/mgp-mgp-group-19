using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

enum Moves
{
	attack,
	dodge
}


public class Attack : MonoBehaviour {

	public int currentPlayer;

	public GameManager gameManager;
	//public bool player1;
	//public bool player2;
    public int player1_hp;
    public int player2_hp;
    public bool Dodge1;
    public bool Dodge2;
    public bool p1Attack;
    public bool p2Attack;


	Moves player1Move;
	Moves player2Move;


	// Use this for initialization
	void Start () {
        player1_hp = 3;
        player2_hp = 3;
        Dodge1 = false;
        Dodge2 = false;
        p1Attack = false;
        p2Attack = false;
		currentPlayer = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (player2_hp == 0 && player1_hp >= 1)
		{
			Debug.Log ("Player health is at 0 and we should be loading a new scene");
			SceneManager.LoadScene ("Player 1 Win");
		}

		if (player1_hp == 0 && player2_hp >= 1)
		{
			Debug.Log ("Player health is at 0 and we should be loading a new scene");
			SceneManager.LoadScene ("Player 2 Win");
		}

		if (player1_hp == 0 && player2_hp == 0)
		{
			Debug.Log ("Player health is at 0 and we should be loading a new scene");
			SceneManager.LoadScene ("Player Draw");
		}
	}
		

	public void PlayerAttack()
	{
		if (currentPlayer == 1)
		{
			player1Move = Moves.attack;
            player2_hp -= 1;
            p1Attack = true;
			GameObject g = GameObject.Find("Player 2 health");
			Player_2_health bScript =  g.GetComponent<Player_2_health>();
			bScript.updateHealthPlayer2(player2_hp);
			Debug.Log("Player 1 attack");
			currentPlayer = 2;
			Debug.Log("Player 2 turn");

			//GameManager gameManagerScript =  g.GetComponent<GameManager>();
			//gameManagerScript.NextTurn (currentPlayer = 1);
		}

	

		//gameManager.NextTurn ();
	}

	public void Player2Attack()
	{
		if (currentPlayer == 2)
		{
			player2Move = Moves.attack;
			p2Attack = false;
			player1_hp -= 1;
			GameObject g = GameObject.Find("Player 1 health");
			Player_1_health bScript2 =  g.GetComponent<Player_1_health>();
			bScript2.updateHealthPlayer1(player1_hp);
			Debug.Log("Player 2 attack");
			currentPlayer = 1;
			Debug.Log("Player 1 turn");
		}
	}

	public void Dodge()
	{
		if (gameManager.CurrentPlayer == 1)
		{
			Debug.Log("Player 1 dodge");
            Dodge1 = true;
		}

		if (gameManager.CurrentPlayer == 2)
		{
			Debug.Log("Player 2 dodge");
            Dodge2 = true;
		}

		gameManager.NextTurn ();
	}

	public void Fight()
	{
        if (Dodge1 == true && p2Attack == true)
        {
            print("Dodge succesful!");
        }  else if (Dodge2 == true && p1Attack == true)
        {
            print("Dodge succesful!");
        }
        else
        {
            PlayerAttack();
        }
		
	}
}
	