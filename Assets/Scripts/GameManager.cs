using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {

	private bool gameHasEnded = false;
	
	public Rotator rotator;
	public Spawner spawner;
	public Animator animator;
	public Text tryText;
	public Text highText;
	private int tries;
	private int count;
	public static int HighScorePassed = 0;
	public static int triesPassed = 3;


	public void Start() {
		tries = triesPassed;
		tryText.text = "Tries: " + tries.ToString();
		highText.text = "High Score: " + HighScorePassed.ToString();
	}

	public void EndGame () {
		if (gameHasEnded)
			return;

		rotator.enabled = false;
		spawner.enabled = false;

		animator.SetTrigger("EndGame");

		gameHasEnded = true;
	}

	public void LevelManager() {
		if (tries >= 2) {
			tries = tries - 1;
			count = Score.PinCount - 1;
			triesPassed = tries;
			if (count > HighScorePassed)
				HighScorePassed = count;
			SceneManager.LoadScene("MainLevel");
		}
		else {
			count = Score.PinCount - 1;
			if (count > HighScorePassed)
				HighScorePassed = count;
			SceneManager.LoadScene("Credits");
			tries = 3;
		}
	}
}
