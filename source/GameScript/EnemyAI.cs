using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	CharacterStatus status;

	CharacterMove charaMove;

	Transform attackTarget;

	private GameObject player;
	//******************************************************
	public float waitBaseTime = 2.0f;//待機時間は2秒とする

	float waitTime;//残り待機時間

	public float walkRange = 800.0f;//移動範囲800メートル

	public Vector3 basePosition;//初期位置を保存しておく変数
	//******************************************************

	public int AttackCnt = 60;

	public GameObject Effect;

	private Vector3 localPosition;

	enum State{
		move,
		chase,
		attack, 
	};

	State state = State.move;
	State nextState = State.move;

	void Start () {
		status = GetComponent<CharacterStatus>();
		charaMove = GetComponent<CharacterMove>();

		player = GameObject.FindWithTag("Player");
		//******************************************************
		basePosition = transform.position;//初期位置を保持

		waitTime = waitBaseTime;//待機時間
		//******************************************************
		Effect.GetComponent<ParticleSystem> ().particleSystem.Stop();
		//particleSystem.Stop();		//Effect.particleSystem.Stop ();



	}
	
		void Update () {

		//Debug.Log (state);

		switch(state){
		case State.move:
			move ();
			break;

		case State.attack:
			attack();
			break;

		case State.chase:
			chase ();
			AttackCnt--;
			break;
		}

		if (state != nextState) {
			state = nextState;
				}

	}

	void move(){

		//******************************************************
		if (waitTime > 0.0f) {
						waitTime -= Time.deltaTime;//待機時間を減らす

						if (waitTime <= 0.0f) {//待機時間が無くなったら
								Vector2 randomValue = Random.insideUnitCircle * walkRange;

								
								Vector3 destinationPosition = basePosition + new Vector3 (randomValue.x, 0.0f, randomValue.y);
			
								SendMessage ("SetDestination", destinationPosition);
						}
				} else {
					if(charaMove.arrived == true){
						waitTime = Random.Range(waitBaseTime, waitBaseTime*2.0f);
					}
			}

						

		//******************************************************
	}

	void ChangeChase(){
			ChangeState(State.chase);
		}

	void attack(){
		Effect.particleSystem.Play();
		if (Vector3.Distance (player.transform.position, transform.position) > 50.0f) {
			Debug.Log("HANI gai");
			ChangeState(State.chase);
			
			Effect.particleSystem.Play();
			
			//ChangeState(State.attack);
		}
	}

	void chase(){

		SendMessage ("SetDestination", player.transform.position);
		SendMessage("CharaMove");
		//particleSystem.Play();
	      if (Vector3.Distance (player.transform.position, transform.position) <= 50.0f) {
			Debug.Log("50M KENNAI");
			ChangeState(State.attack);

			Effect.particleSystem.Play();

			//ChangeState(State.attack);
		}
	}

	void ChangeState(State nextState){
		this.nextState = nextState;
		}

	public void SetAttackTarget(Transform target){
		//attackTarget = target;
		}
}
