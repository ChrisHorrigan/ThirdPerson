using UnityEngine;
using System.Collections;

public class Looky : MonoBehaviour {
	float sensitivity=5f;
	float mouseY=0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		mouseY = -Input.GetAxis ("Mouse Y");
		if (mouseY != 0) {
			if(mouseY>0&&transform.localRotation.x>=20)
				transform.Translate(new Vector3(0,0,1));
			else if (mouseY<0&&transform.localRotation.x>=180)//local?
				transform.Translate (new Vector3(0,0,-1));
				}

		Vector3 rot = transform.localEulerAngles;
		rot.x += mouseY * sensitivity;
		transform.localEulerAngles = rot;
	//	if (transform.localRotation.x >= 20)
					//	transform.Translate (new Vector3 (0, 0, 1));
				//else if (transform.localPosition.x
					//	transform.Translate (new Vector3 (0, 0, -1));
	}
}
