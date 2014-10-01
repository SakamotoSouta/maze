using UnityEngine;
using System.Collections;

public class TitleScript : MonoBehaviour {

	public GUIStyle labelStyle;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Return)) {
			Application.LoadLevel("Game");
		}
	}

	// OnGUI
	void OnGUI(){
		int sw = Screen.width;
		int sh = Screen.height;

		GUI.Label (new Rect (0, sh / 4, sw, sh / 4), "Test @ BALL MAZE", labelStyle);
		GUI.Label (new Rect (0, sh / 2, sw, sh / 4), "Press ENTER", labelStyle);
	}
}
