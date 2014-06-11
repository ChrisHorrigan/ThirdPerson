using UnityEngine;
using System.Collections;

public class Lookx : MonoBehaviour {

	float mouseX=0f;
	float mouseSensitivity=5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		mouseX = Input.GetAxis ("Mouse X");
		Vector3 rot = transform.localEulerAngles;
		rot.y += mouseX*mouseSensitivity;
		transform.localEulerAngles = rot;
	}
}
