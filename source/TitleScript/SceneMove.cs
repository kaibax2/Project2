using UnityEngine;
using System.Collections;

public class SceneMove : MonoBehaviour {


	// Use this for initialization
	void Start () {
		audio.Stop ();
	}
	
	// Update is called once per frame
	void Update () {
		Screen.showCursor = false;
	if (Input.GetKey (KeyCode.Space)) {

			audio.Play();
			FadeManager.Instance.LoadLevel("SelectScene",0.5f);
			//Application.LoadLevel("GarageScene");
				}
	}
}
