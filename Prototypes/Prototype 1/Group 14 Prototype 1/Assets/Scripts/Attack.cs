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
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayerAttack()
	{
		if (gameManager.CurrentPlayer == 1)
		{
			player1Move = Moves.attack;
            player2_hp -= 1;
            p1Attack = true;
			Debug.Log("Player 1 attack");	
		}

		if (gameManager.CurrentPlayer == 2)
		{
            player2Move = Moves.attack;
            p2Attack = false;
            player1_hp -= 1;
			Debug.Log("Player 2 attack");
		}

		gameManager.NextTurn ();
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
	