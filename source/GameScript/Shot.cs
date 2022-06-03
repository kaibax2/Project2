using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour {
	
	enum State{
		dead,
		live,
	};

	State state = State.dead;//現在のステータス
	State nextstate = State.dead;//次のステータス

	public GameObject bullet;
	public Transform spawn;
	public float speed = 1000;

	public int M4A1direi=6;
	public int RDdirei=6;
	public int P90direi=6;


	// Update is called once per frame(毎フレーム呼ばれる)
	void FixedUpdate () {

		switch(testWeaponChange.changeCnt) {
		case 1:
	
			if (Input.GetButton ("Fire1")) {

				M4A1direi--;
				if (M4A1direi == 6) {
					if (state == nextstate) {
						state = State.live;
						M4A1direi = 15;
					}
				}
			if (state == State.live)
				Shoot ();				

			if (M4A1direi > 8)
				state = nextstate;
			
			}
			break;
		case 2:
	
			if (Input.GetButton ("Fire1")) {
				RDdirei--;
				if (RDdirei == 6) {
					if (state == nextstate) {
						state = State.live;
						RDdirei = 30;
					}
				}
				if (state == State.live)
					Shoot ();				
				
				if (RDdirei > 8)
					state = nextstate;
			}
			break;

		case 3:
		
			if (Input.GetButton ("Fire1")) {
				P90direi--;
				if (P90direi == 6) {
					if (state == nextstate) {
						state = State.live;
						P90direi = 10;
					}
				}
				if (state == State.live)
					Shoot ();				
				
				if (P90direi > 8)
					state = nextstate;
			}
			break;
		}
	}

	
	void Shoot () {
		GameObject obj = GameObject.Instantiate(bullet)as GameObject;
		obj.transform.position = spawn.position;
		Vector3 force;
		force = this.gameObject.transform.forward * speed;
		obj.rigidbody.AddForce (force);
		audio.Play ();
	}

	void Direi(){

	}
}
