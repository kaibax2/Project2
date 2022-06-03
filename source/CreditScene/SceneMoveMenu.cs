using UnityEngine;
using System.Collections;

public class SceneMoveMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Screen.showCursor = false;
		if(Input.GetKeyDown(KeyCode.Return))FadeManager.Instance.LoadLevel("SelectScene",0.5f);
	}
}
