using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	CharacterController controller;
	// Use this for initialization
	[SerializeField]
	float moveSpeed=25f;
	[SerializeField]
	float jumpSpeed=1f;
	[SerializeField]
	float gravity=1f;

	float yVelocity=0f;
	void Start () {
		 controller= GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		Vector3 velocity = direction * moveSpeed;
		if (controller.isGrounded) {
				if (Input.GetButtonDown ("Jump"))
						yVelocity = jumpSpeed;
				} 
		else
				yVelocity -= gravity;

		velocity.y = yVelocity;
		velocity = transform.TransformDirection(velocity);
		controller.Move (velocity*Time.deltaTime);
	}
}
