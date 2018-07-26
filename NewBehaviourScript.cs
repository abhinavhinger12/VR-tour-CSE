using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	public GameObject Asphalt;
	public GameObject Sidewalk;
	public GameObject Steps;

	private bool walking = false;
	private Vector3 spawnPoint;

	// Use this for initialization
	void Start () {
		spawnPoint = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		if (walking)
		{
			transform.position = transform.position + Camera.main.transform.forward* 3 * Time.deltaTime;
		}

		if (transform.position.y < -30f) {
			transform.position = spawnPoint;
		}

		Ray ray = Camera.main.ViewportPointToRay (new Vector3 (.5f, .5f, 0));
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit)) {

			if (hit.collider.name.Contains ("Asphalt") || hit.collider.name.Contains ("Sidewalk") || hit.collider.name.Contains ("Steps")) {
				walking = true;
			}
			else {
				walking = false;
			}
		}
		
	}
}
