 using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	
	//float axisValue = 0;
	//public float value=10.0f;

	public Vector3 Position;
	public float speed;
	public float LinerDrag = 30.0f;
	//public float rotationSpeed = 100.0F;
	public Vector3 gravity;	
	// Use this for initialization
	private int boostCnt = 10;
	
	public Vector3 localPosition;

	private bool Up_t;
	private bool Down_t;

	private int cooltimeCnt = 30;

	enum State{
		cooltime,
		boost,
		ready,
	};
	
	State state = State.ready;//現在のステータス
	State nextstate = State.ready;//次のステータス

	void Start () {
		gravity = new Vector3(0, -9.81f+9.70f , 0);

	}

	void FixedUpdate () {
		// 加速度与える
		rigidbody.AddForce(gravity, ForceMode.Acceleration);
	}
	
	// Update is called once per frame
	void Update () {

		QuickBoost ();

		float deltatime = Time.deltaTime;

		float translation = 
			Input.GetAxis ("Vertical") * speed;
		
		float rotation = 
			Input.GetAxis ("Horizontal") * speed;

	
		float up = 0;
		if (Input.GetKey (KeyCode.Space)) {
						Up_t = true;
						up = 1 * speed;
						gravity = new Vector3 (0, -9.81f + 9.50f, 0);
				} else {
			Up_t = false;
				}

		float down = 0;
		if (Input.GetKey (KeyCode.V)) {
						Down_t = true;
						gravity = new Vector3 (0, -9.81f, 0);
				} else {
			Down_t = false;
				}


		
		translation *= 
			Time.deltaTime;
		
		rotation *= 
			Time.deltaTime;


		up *= Time.deltaTime;

		
		transform.Translate (0, 0, translation);
		transform.Translate (rotation, 0, 0);

		if (Up_t) {
						transform.Translate (0, up, 0);
				} else {
			//transform.position.y = localPosition.y;
				}


	}

	void QuickBoost(){

		switch (state) {
		case State.ready:
			cooltimeCnt = 30;
			if (Input.GetKey (KeyCode.F)) {
				speed = 100;
				state = State.boost;
			}
			break;

		case State.boost:
			boostCnt--;
			if(boostCnt <= 0){
				speed = 20;
				boostCnt = 10;
				state = State.cooltime;
			}
			break;

		case State.cooltime:
	
			cooltimeCnt--;
			if(cooltimeCnt <= 0)
				state = State.ready;
			break;
		}

		
	}
	
}
