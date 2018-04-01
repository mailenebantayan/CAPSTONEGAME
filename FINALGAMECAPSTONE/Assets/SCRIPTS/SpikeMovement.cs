using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMovement : MonoBehaviour {

	public float speed = .5f;
	public GameObject character;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		double distancey = transform.position.y + 2;
		double distancex = transform.position.x + 2;

		if (transform.position.x <= character.transform.position.x && distancex >= character.transform.position.x || distancey >= character.transform.position.y && transform.position.y <= character.transform.position.y) {
			
				transform.Translate (0, -speed * Time.deltaTime, 0);
		
		} else {
				transform.Translate (0, speed * Time.deltaTime, 0);
		
		}




	}
}
