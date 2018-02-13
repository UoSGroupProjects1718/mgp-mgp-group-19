using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	[Header("Number of players")]
	public int maxPlayers;
	int currentPlayer;


	public int CurrentPlayer{ get { return currentPlayer; } }

	//public float countdownTimer;
	//public Text timer;

	// Use this for initialization
	void Start () {
		currentPlayer = 1;

		//countdownTimer = 20;
		//StartCoroutine (countdown ());
	}
	
	// Update is called once per frame
	void Update () {
		//countdownTimer -= Time.deltaTime;
		//timer.text = Mathf.Round (countdownTimer).ToString ();
	}

	/*IEnumerator countdown(){
		//yield return new WaitForSeconds (20f);
		//NextTurn ();
	}*/

	public void NextTurn()
	{
		currentPlayer++;
		if (currentPlayer > maxPlayers) {
			currentPlayer = 1;
		}
		//countdownTimer = 20;
		//StartCoroutine (countdown ());
	}
}
