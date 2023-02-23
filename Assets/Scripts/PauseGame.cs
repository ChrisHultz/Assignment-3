using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour {
    
    private bool isPaused = false;
    public GameObject objectToDisable;
    public Text pauseText;
    public Text playerText;

    public void Awake() {
		playerText.text = Menu.pass;
	}

    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(isPaused) {
                pauseText.enabled = false;
                ResumeGame();
            }
            else {
                pauseText.enabled = true;
                Pause();
            }
        }
        if (!isPaused) {
            pauseText.text = "Game is paused";
        }
    }

    void Pause() {
        playerText.enabled = false;
        objectToDisable.SetActive(false);
        Time.timeScale = 0;
        isPaused = true;
        pauseText.text = "Game is paused";
    }
    public void ResumeGame() {
        playerText.enabled = true;
        objectToDisable.SetActive(true);
        Time.timeScale = 1;
        isPaused = false;
    }
}