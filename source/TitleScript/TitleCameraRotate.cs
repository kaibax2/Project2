﻿using UnityEngine;
using System.Collections;

public class TitleCameraRotate : MonoBehaviour {

	private float rotate = 0.05f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0.0f, rotate, 0.0f);
	}
}
