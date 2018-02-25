using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {


	private static GameManager instance;

	[Header("Number of players")]
	public int maxPlayers;
	public int currentPlayer;


	public int CurrentPlayer{ get { return currentPlayer; } }

	public static GameManager Instance { get { return instance; } }

	//public float countdownTimer;
	//public Text timer;

	// Use this for initialization
	void Start () {

		// If the singleton doesnt exist yet 
		if (instance == null) {

			// Set this as the singleton
			instance = this;

			// Dont destroy this object as we change scenes
			DontDestroyOnLoad (this.gameObject);
		}
		// Otherwise, if the singleton already exists...
		else {
			// Destroy this
			Destroy(this.gameObject);
		}


		maxPlayers = 2;
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
