using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour {
    public static float RotatorSpeed = 200f;
    public static float PinSpeed = 50f;

    public Slider RotatorSpeedSlider;
    public Slider PinSpeedSlider;

    public Image SettingColor;

    public Dropdown RotatorColor;

    private int pass;
    public static int RotatorInt = 1;

    public Text RotatorSpeedText;
    public Text PinSpeedText;
    public Text rotateColorTxt;

     public void Awake() {
        if (RotatorInt == 1) 
			SettingColor.color = Color.black;
		else if (RotatorInt == 2) 
			SettingColor.color = Color.blue;
		else if (RotatorInt == 3) 
			SettingColor.color = Color.red;
		else if (RotatorInt == 4)
			SettingColor.color = Color.green;
		else
			SettingColor.color = Color.black;
     }

    public void BackToMenu() {
        SceneManager.LoadScene("Menu");
    }
    public void calcRotateSpeed() {
        RotatorSpeedText.text = RotatorSpeedSlider.value.ToString();
        RotatorSpeed = RotatorSpeedSlider.value;
    }

    public void calcPinSpeed() {
        PinSpeedText.text = PinSpeedSlider.value.ToString();
        PinSpeed = PinSpeedSlider.value;
    }

    public void ChooseRotatorColor() {
        switch (RotatorColor.value) {
            case 1:
                pass = 1;
                RotatorInt = pass;
                rotateColorTxt.text = RotatorColor.options[1].text;
                SettingColor.color = Color.black;
                break;
            case 2:
                pass = 2;
                RotatorInt = pass;
                rotateColorTxt.text = RotatorColor.options[2].text;
                SettingColor.color = Color.blue;
                break;
            case 3:
                pass = 3;
                RotatorInt = pass;
                rotateColorTxt.text = RotatorColor.options[3].text;
                SettingColor.color = Color.red;
                break;
            case 4:
                pass = 4;
                RotatorInt = pass;
                rotateColorTxt.text = RotatorColor.options[4].text;
                SettingColor.color = Color.green;
                break;
            default:
                pass = 1;
                RotatorInt = pass;
                rotateColorTxt.text = RotatorColor.options[0].text;
                SettingColor.color = Color.black;
                break;
        }
    }

}
