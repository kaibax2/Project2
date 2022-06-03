using UnityEngine;
using System.Collections;

public class SearchArea : MonoBehaviour {
	enum State{
		move,
		chase,
		attack, 
	};

	public GameObject SearchObj;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		 
	}

	void OnTriggerEnter(Collider other){
		
		if (other.tag == "Player") {
			//ChangeState(State.chase);
			SearchObj.SendMessage("ChangeChase");
			Debug.Log ("HitPlayer");
		} else {
			//Debug.Log("NonHitPlayer");
		}
	}
}
