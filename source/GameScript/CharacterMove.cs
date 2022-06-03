using UnityEngine;
using System.Collections;

public class CharacterMove : MonoBehaviour {

	const float StoppingDistance = 0.6f;//目的地に着いたとみなす停止距離
	
	Vector3 velocity = Vector3.zero;//現在の移動速度

	CharacterController characterController;//キャラクターコントローラーのキャッシュ

	public bool arrived = false;//到着したか（true:到着した/false:到着していない）

	bool forceRotate = false;//向きを強制的に指示するか
		
	Vector3 forceRotateDirection;//強制的に向かせたい方向
	
	public Vector3 destination;//目的地
	
	public float walkSpeed = 6.0f;//移動速度
	
	public float rotationSpeed = 360.0f;//回転速度

	public int moveflag=0;

	void Start () {
	
		characterController = GetComponent<CharacterController>();
		destination = transform.position;
	
	}

	void FixedUpdate(){
		//if(characterController.isGrounded == false){
			Vector3 destinationXZ = destination;
		if (moveflag == 0) {
						destinationXZ.y = transform.position.y;//高さを目的地と現在地を同じにしておく
				}
			//**************とりあえずXZ移動として考える*****************
			//目的地までの距離と方向を求める
			Vector3 direction = (destinationXZ - transform.position).normalized;
			
			float distance = Vector3.Distance(transform.position, destinationXZ);
			
			Vector3 currentVelocity = velocity;//現在の速度を退避
			
			if(arrived || distance < StoppingDistance)//目的地に近づいたら到着
				arrived = true;
			
			if(arrived)//移動速度を求める
				velocity = Vector3.zero;
			else
				velocity = direction * walkSpeed;//移動速度ベクトル＝方向ベクトル×移動速度
			
			velocity = Vector3.Lerp(currentVelocity, velocity,
			                        Mathf.Min(Time.deltaTime * 5.0f, 1.0f));//スムーズに補間
			velocity.y = 0;

			Vector3 idouryou = velocity * 1/60;

			transform.position = this.transform.position + idouryou;
			
			if(!forceRotate){
				//向きたい方向に向ける
				if(velocity.magnitude > 0.1f && !arrived){//移動していなかったら向きは更新しない
					Quaternion characterTargetRotation = 
					   Quaternion.LookRotation (direction);
					transform.rotation = 
					Quaternion.RotateTowards(transform.rotation, 
					                         characterTargetRotation,
					                         rotationSpeed * Time.deltaTime);
				}
			}else {
				//強制向き指定
				Quaternion characterTargetRotation = 
					Quaternion.LookRotation(forceRotateDirection);
				transform.rotation = 
				Quaternion.RotateTowards(transform.rotation, 
				                         characterTargetRotation, 
				                         rotationSpeed * Time.deltaTime);
			}
		//}
		
		//UnityのCharacterControllerの特性のため
		/*Vector3 snapGround = Vector3.zero;
		if (characterController.isGrounded)
			snapGround = Vector3.down;*/
		
		//characterControllerを使って動かす
		characterController.Move (velocity * Time.deltaTime /*+ snapGround*/);
		
		//if (characterController.velocity.magnitude < 0.1f)
			//arrived = true;
		
		//強制的に向きを変えるのを解除
		if (forceRotate && Vector3.Dot (transform.forward,
		                                forceRotateDirection) > 0.99f)
		forceRotate = false;

	}


	//目的地を設定する。引数destinationは目的地
	public void SetDestination(Vector3 destination){
		arrived = false;
		this.destination = destination;
	}
	
	//指定した向きを向かせる
	public void SetDirection(Vector3 direction){
		forceRotateDirection = direction;
		forceRotateDirection.y = 0;
		forceRotateDirection.Normalize ();
		forceRotate = true;
	}
	
	//移動をやめる
	public void StopMove(){
		destination = transform.position;//現在地を目的地にしてしまう
	}
	
	bool Arrived(){
		return arrived;
	}

	public void CharaMove(){
		moveflag = 1;
		}

}
