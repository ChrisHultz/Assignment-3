using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {
    private int lives = 3;
    public Text playerText;
    public Text passingHighScore;

    public void Awake() {
        playerText.text = Menu.pass.ToUpper();
        passingHighScore.text = "High Score: " + GameManager.HighScorePassed.ToString();
    }

    public void BackToMenu() {
        SceneManager.LoadScene("Menu");
    }
    public void Retry() {
        SceneManager.LoadScene("MainLevel");
        GameManager.triesPassed = lives;
    }
    public void Exit() {
        UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("I quit...");
    }
}
