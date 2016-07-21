using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3  offset;

	//Use this for installation
	void Start() {
		offset = transform.position - player.transform.position;
	}

	//Update is called once per frame
	void LastUpdate () { 
		transform.position = player.transform.position + offset;
	}
}
