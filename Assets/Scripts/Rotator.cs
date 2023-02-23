using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	private float speed = Settings.RotatorSpeed;
	public SpriteRenderer rotatorThing;
	static int RotatorColor;

	void Update () {
		transform.Rotate(0f, 0f, speed * Time.deltaTime);
	}
	
	public void Start() {
		
		RotatorColor = Settings.RotatorInt;
		if (RotatorColor == 1) 
			rotatorThing.color = Color.black;
		else if (RotatorColor == 2) 
			rotatorThing.color = Color.blue;
		else if (RotatorColor == 3) 
			rotatorThing.color = Color.red;
		else if (RotatorColor == 4)
			rotatorThing.color = Color.green;
		else
			rotatorThing.color = Color.black;
		
	}

}
