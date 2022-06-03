using UnityEngine;
using System.Collections;

public class testEffect2 : MonoBehaviour {
	public int cnt;
	// Use this for initialization
	void Start () {
		particleSystem.Stop();
		cnt = 240;
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKey(KeyCode.T)) {
			cnt--;
			if(cnt > 0){
				particleSystem.Play();
			}else if(cnt <= 0){
				particleSystem.Stop();
				cnt = 240;
			}
		}
	}
}
