﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

enum Moves
{
	attack,
	dodge
}


public class Attack : MonoBehaviour {

	public int currentPlayer;

    public int player1_hp;
    public int player2_hp;

    public Button player1_Attackb;
    public Button player2_Attackb;

    public Button player1_Dodgeb;
    public Button player2_Dodgeb;

    public bool is1Clicked;
    public bool is2Clicked;
    public bool is1dClicked;
    public bool is2dClicked;

    public GameObject Ref_to_attack;
    public GameObject Ref_to_pendulum;

    public bool Attack1Success;
    public bool Attack2Success;
    public bool Dodge1Success;
    public bool Dodge2Success;

    Moves player1Move;
	Moves player2Move;

	// Use this for initialization
	void Start () 
	{
        player1_hp = 3; //Sets player 1 health to 3
        player2_hp = 3; //Sets player 2 health to 3
		currentPlayer = 1; //Sets the current player to 1
        player1_Attackb.onClick.AddListener(isAttackClicked);
        player2_Attackb.onClick.AddListener(isAttack2Clicked);
        player1_Dodgeb.onClick.AddListener(isDodgeClicked);
        player2_Dodgeb.onClick.AddListener(isDodge2Clicked);
        is1Clicked = false;
        is2Clicked = false;
        is1dClicked = false;
        is2dClicked = false;
        Attack1Success = false;
        Attack2Success = false;
        Dodge1Success = false;
     }

    public void isDodgeClicked()
    {
        is1dClicked = true;
    }
    public void isDodge2Clicked()
    {
        is2dClicked = true;
    }
    public void isAttackClicked()
    {
        is1Clicked = true;
    }
    public void isAttack2Clicked()
    {
        is2Clicked = true;
    }
	
	// Update is called once per frame
	void Update () 
	{
		if (player2_hp == 0 && player1_hp >= 1) //If the player 2 health is 0 and player 1 health is higher or equal to 1 then load player 1 win scene
		{
			SceneManager.LoadScene ("Player 1 Win");
		}

		if (player1_hp == 0 && player2_hp >= 1) //If the player 1 health is 0 and player 2 health is higher or equal to 1 then load player 2 win scene
		{
			SceneManager.LoadScene ("Player 2 Win");
		}

		if (player1_hp == 0 && player2_hp == 0) //If the player 1 health and player 2 health is 0 then load the draw screen
		{
			SceneManager.LoadScene ("Player Draw");
		}
        if (currentPlayer == 1 && Input.GetMouseButtonDown(0) && (is1Clicked == true || is1dClicked == true))
        {
            currentPlayer = 2;
        }else if (currentPlayer == 2 && Input.GetMouseButtonDown(0) && (is2Clicked == true || is2dClicked == true))
        {
            Player3Attack();
        }
	}

	public void PlayerAttack()
	{
		if (currentPlayer == 1) //If the current player equals 1
		{
            player2_Attackb.interactable = true;
            player1_Attackb.interactable = false;
            player2_Dodgeb.interactable = true;
            player1_Dodgeb.interactable = false;

            is1Clicked = false;
            is1dClicked = false;
            is2Clicked = false;
            is2dClicked = false;
        }

	}

	public void Player2Attack()
	{
		if (currentPlayer == 2)
		{
            player2_Attackb.interactable = false;
            player1_Attackb.interactable = true;
            player2_Dodgeb.interactable = false;
            player1_Dodgeb.interactable = true;
        
            is1Clicked = false;
            is1dClicked = false;
            is2Clicked = false;
            is2dClicked = false;
        }
	}

    public void Player3Attack()
    {
        currentPlayer = 3;
        if (currentPlayer == 3)
        {
            if (Attack1Success == true && Attack2Success == true)
            {
                Debug.Log("Something!");
                player2_hp -= 1;
                GameObject g = GameObject.Find("Player 2 health");
                Player_2_health bScript2 = g.GetComponent<Player_2_health>();
                bScript2.updateHealthPlayer2(player2_hp);

                player1_hp -= 1;
                GameObject j = GameObject.Find("Player 1 health");
                Player_1_health bScript = j.GetComponent<Player_1_health>();
                bScript.updateHealthPlayer1(player1_hp);
            }
            else if (Attack1Success == true && Dodge2Success == true)
            {
                Debug.Log("Something2!");
            }
            else if (Dodge1Success == true && Attack2Success == true)
            {
                Debug.Log("Something3!");
            }
            else if (Dodge1Success == true && Dodge2Success == true)
            {
                Debug.Log("Something!4");
            }
            else if (Attack1Success == true && Dodge2Success == false)
            {
                Debug.Log("Something!5");
                player2_hp -= 1;
                GameObject g = GameObject.Find("Player 2 health");
                Player_2_health bScript2 = g.GetComponent<Player_2_health>();
                bScript2.updateHealthPlayer2(player2_hp);
            }
            else if (Dodge1Success == false && Attack2Success == true)
            {
                Debug.Log("Something!6");
                player1_hp -= 1;
                GameObject j = GameObject.Find("Player 1 health");
                Player_1_health bScript = j.GetComponent<Player_1_health>();
                bScript.updateHealthPlayer1(player1_hp);
            }
            Attack1Success = false;
            Attack2Success = false;
            Dodge1Success = false;
            Dodge2Success = false;
            currentPlayer = 1;
        }
    }

	
}
	