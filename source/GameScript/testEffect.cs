using UnityEngine;
using System.Collections;

public class testEffect : MonoBehaviour {

	public GameObject hitEffect;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.P)) {
			Debug.Log("EffectON");
			Effect();
				}
	}

	void Effect(){
		GameObject effect = Instantiate (hitEffect, transform.position, 
		                                 Quaternion.identity) as GameObject;
		effect.transform.localPosition = transform.position + new Vector3 (0.0f, 1.0f, 0.0f);
		//Destroy (effect, 100.0f);
	}
}
