using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject pinPrefab;
	public Camera myCam;

	void Update ()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			myCam.GetComponent<AudioSource>().Play();
			SpawnPin();
		}
	}

	void SpawnPin ()
	{
		Instantiate(pinPrefab, transform.position, transform.rotation);
	}

}
