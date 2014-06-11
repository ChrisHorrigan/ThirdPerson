using UnityEngine;
using System.Collections;

public class RifleWeapon : MonoBehaviour {
	float fireDelay=1f;
	float nextFire=1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)&&Time.time>=nextFire) 
		{
			nextFire+=fireDelay;
			print ("Shootin");
			Ray mouseRay=Camera.main.ViewportPointToRay(new Vector3(.5f,.5f,0));
			RaycastHit hitInfo;
			if(Physics.Raycast(mouseRay,out hitInfo))
				print ("Hit somethin'");
				}
	
	}
}
