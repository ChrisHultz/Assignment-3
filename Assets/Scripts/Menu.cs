using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public InputField input;
    public Text inputText;
    private string playerInput;
    public static string pass = "Player";
    private int lives = 3;

    public void StartGame() {
        SceneManager.LoadScene("MainLevel");
        GameManager.triesPassed = lives;
    }
    public void SettingsPage() {
        SceneManager.LoadScene("Settings");
    }

    public void inputName() {
        pass = input.text.ToString();
        inputText.text = pass.ToUpper();
    }
}
