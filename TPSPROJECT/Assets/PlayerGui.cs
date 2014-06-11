using UnityEngine;
using System.Collections;

public class PlayerGui : MonoBehaviour {
	[SerializeField]
	Texture2D crosshair;
	void OnGUI(){
		Screen.lockCursor = true;
		float x = (Screen.width - crosshair.width) / 2;
		float y = (Screen.height - crosshair.height) / 2;
		GUI.DrawTexture(new Rect(x, y, crosshair.height, crosshair.width), crosshair);
		}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
