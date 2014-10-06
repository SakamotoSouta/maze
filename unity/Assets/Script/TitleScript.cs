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

}
